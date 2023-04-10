using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationSpeed = 10.0f;
    private bool putar;

    void Update()
    {
        if (putar)
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
    }

    public void ObjectRotate (){
        putar = true; 
    }

    public void stopRotate(){
        putar = false;
    }

}
