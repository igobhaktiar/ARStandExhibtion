using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowObjectBundle : MonoBehaviour
{
    public GameObject stand1;
    public GameObject stand2;
    public GameObject stand3;
    public GameObject button;
    

    // Start is called before the first frame update
    void Start()
    {
        button.SetActive(false);
        stand1.SetActive(false);
        stand2.SetActive(false);
        stand3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Stand1(){
        stand1.SetActive(true);
        stand2.SetActive(false);
        stand3.SetActive(false);
        if(button.activeInHierarchy == true){
            button.SetActive(false);
        } else{
            button.SetActive(true);
        }
    }

    public void Stand2(){
        stand1.SetActive(false);
        stand2.SetActive(true);
        stand3.SetActive(false);
    }

    public void Stand3(){
        stand1.SetActive(false);
        stand2.SetActive(false);
        stand3.SetActive(true);
    }
}
