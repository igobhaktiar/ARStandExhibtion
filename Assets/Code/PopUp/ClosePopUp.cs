using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePopUp : MonoBehaviour
{
    public GameObject imageToClose;

    public void closePopUp (){
        if(imageToClose.activeInHierarchy == true){
            imageToClose.SetActive(false);
        }
    }
}
