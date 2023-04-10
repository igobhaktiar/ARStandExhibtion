using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneMenu : MonoBehaviour
{
    public void loadMenu(){
        SceneManager.LoadScene("menu");
    }

    public void freeMode(){
        SceneManager.LoadScene("FreeMode");
    }

    public void bundlingMode(){
        SceneManager.LoadScene("BundlingMode");
    }

    public void loadData(){
        SceneManager.LoadScene("LoadObject");
    }

}
