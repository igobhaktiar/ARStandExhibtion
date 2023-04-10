using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManagerScript : MonoBehaviour
{
    public List<GameObject> objectList;
    private AndroidJavaClass toastClass;
    private AndroidJavaObject toastObject;

    void Start() {
        // Initialize the AndroidJavaClass and AndroidJavaObject for the toast messages
        toastClass = new AndroidJavaClass("android.widget.Toast");
        toastObject = toastClass.CallStatic<AndroidJavaObject>("makeText", new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity"), "", toastClass.GetStatic<int>("LENGTH_SHORT"));
    }


    public void SaveData() {
        bool success = true;
        foreach (GameObject obj in objectList) {
            // Save position, rotation, scale, material, and active state of each object using PlayerPrefs
            // For example:
            try{
            PlayerPrefs.SetFloat(obj.name + "_PosX", obj.transform.position.x);
            PlayerPrefs.SetFloat(obj.name + "_PosY", obj.transform.position.y);
            PlayerPrefs.SetFloat(obj.name + "_PosZ", obj.transform.position.z);
            PlayerPrefs.SetFloat(obj.name + "_RotX", obj.transform.rotation.x);
            PlayerPrefs.SetFloat(obj.name + "_RotY", obj.transform.rotation.y);
            PlayerPrefs.SetFloat(obj.name + "_RotZ", obj.transform.rotation.z);
            PlayerPrefs.SetFloat(obj.name + "_RotW", obj.transform.rotation.w);
            PlayerPrefs.SetFloat(obj.name + "_ScaleX", obj.transform.localScale.x);
            PlayerPrefs.SetFloat(obj.name + "_ScaleY", obj.transform.localScale.y);
            PlayerPrefs.SetFloat(obj.name + "_ScaleZ", obj.transform.localScale.z);
            Renderer renderer = obj.GetComponent<Renderer>();
            if (renderer != null && renderer.sharedMaterial != null) {
                PlayerPrefs.SetString(obj.name + "_MaterialName", renderer.sharedMaterial.name);
            }
            PlayerPrefs.SetInt(obj.name + "_Active", obj.activeSelf ? 1 : 0);
            // Repeat for rotation, scale, material, etc.
            }
            
            catch (PlayerPrefsException e) {
                Debug.LogError("Error saving data: " + e);
                success = false;
            
            }
        }
        PlayerPrefs.Save();
        if (success) {
            // Show success toast message
            toastObject.Call("setText", "Data saved successfully");
            toastObject.Call("show");
        }
        else {
            // Show failure toast message
            toastObject.Call("setText", "Error saving data");
            toastObject.Call("show");
        }
    }

    public void LoadData() {
        bool success = true;
        foreach (GameObject obj in objectList) {
            // Load position, rotation, scale, material, and active state of each object from PlayerPrefs
            // For example:
            try {
            obj.transform.position = new Vector3(PlayerPrefs.GetFloat(obj.name + "_PosX"), PlayerPrefs.GetFloat(obj.name + "_PosY"), PlayerPrefs.GetFloat(obj.name + "_PosZ"));
            obj.transform.rotation = new Quaternion(PlayerPrefs.GetFloat(obj.name + "_RotX"), PlayerPrefs.GetFloat(obj.name + "_RotY"), PlayerPrefs.GetFloat(obj.name + "_RotZ"), PlayerPrefs.GetFloat(obj.name + "_RotW"));
            obj.transform.localScale = new Vector3(PlayerPrefs.GetFloat(obj.name + "_ScaleX"), PlayerPrefs.GetFloat(obj.name + "_ScaleY"), PlayerPrefs.GetFloat(obj.name + "_ScaleZ"));
            Renderer renderer = obj.GetComponent<Renderer>();
            if (renderer != null && renderer.sharedMaterial != null && PlayerPrefs.HasKey(obj.name + "_MaterialName")) {
                Material[] materials = renderer.sharedMaterials;
                for (int i = 0; i < materials.Length; i++) {
                    if (materials[i].name == PlayerPrefs.GetString(obj.name + "_MaterialName")) {
                        materials[i] = renderer.sharedMaterial;
                        renderer.sharedMaterials = materials;
                        break;
                    }
                }
            }
            obj.SetActive(PlayerPrefs.GetInt(obj.name + "_Active") == 1);
            // Repeat for rotation, scale, material, etc.
            }
            catch (PlayerPrefsException e) {
                Debug.LogError("Error loading data: " + e);
                success = false;
            }
        }
        if (success) {
            // Show success toast message
            toastObject.Call("setText", "Data loaded successfully");
            
        }
        else {
            // Show failure toast message
            toastObject.Call("setText", "Error loading data");
            toastObject.Call("show");
        }
    }

    public void OnSaveButtonClicked() {
        // toastObject.Call("setText", "Save Data...");
        // toastObject.Call("show");
        SaveData();
    }

    public void OnLoadButtonClicked() {
        // toastObject.Call("setText", "Load Data...");
        // toastObject.Call("show");
        LoadData();
    }
}
