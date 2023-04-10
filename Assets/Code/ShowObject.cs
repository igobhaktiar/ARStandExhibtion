using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowObject : MonoBehaviour
{
    public GameObject bannerproduct1;
    public GameObject bannerproduct2;
    public GameObject kursi1;
    public GameObject kursi2;
    public GameObject kursi3;
    public GameObject kursi4;
    public GameObject kursi5;
    public GameObject kursi6;
    public GameObject kursibundar;
    public GameObject meja;
    public GameObject meja3;
    public GameObject meja4;
    public GameObject rak;
    public GameObject sofa;
    public GameObject standproduct2;
    public GameObject standproduct1;
    // Start is called before the first frame update
    void Start()
    {
        bannerproduct1.SetActive(false);
        bannerproduct2.SetActive(false);
        kursi1.SetActive(false);
        kursi2.SetActive(false);
        kursi3.SetActive(false);
        kursi4.SetActive(false);
        kursi5.SetActive(false);
        kursi6.SetActive(false);
        kursibundar.SetActive(false);
        meja.SetActive(false);
        meja3.SetActive(false);
        meja4.SetActive(false);
        rak.SetActive(false);
        sofa.SetActive(false);
        standproduct1.SetActive(false);
        standproduct2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BannerProduct1(){
        if (bannerproduct1.activeInHierarchy == true){
            bannerproduct1.SetActive(false);
        }
            
        else{
            bannerproduct1.SetActive(true);
        }  
    }

    public void BannerProduct2(){
        if (bannerproduct2.activeInHierarchy == true){
            bannerproduct2.SetActive(false);
        }
            
        else{
            bannerproduct2.SetActive(true);
        }  
    }
    public void Kursi1(){
        if (kursi1.activeInHierarchy == true){
            kursi1.SetActive(false);
        }
            
        else{
            kursi1.SetActive(true);
        }  
    }
    public void Kursi2(){
        if (kursi2.activeInHierarchy == true){
            kursi2.SetActive(false);
        }
            
        else{
            kursi2.SetActive(true);
        }  
    }
    public void Kursi3(){
        if (kursi3.activeInHierarchy == true){
            kursi3.SetActive(false);
        }
            
        else{
            kursi3.SetActive(true);
        }  
    }

    public void Kursi4(){
        if (kursi4.activeInHierarchy == true){
            kursi4.SetActive(false);
        }
            
        else{
            kursi4.SetActive(true);
        }  
    }

    public void Kursi5(){
        if (kursi5.activeInHierarchy == true){
            kursi5.SetActive(false);
        }
            
        else{
            kursi5.SetActive(true);
        }  
    }
    public void Kursi6(){
        if (kursi6.activeInHierarchy == true){
            kursi6.SetActive(false);
        }
            
        else{
            kursi6.SetActive(true);
        }  
    }

    public void KursiBundar(){
        if (kursibundar.activeInHierarchy == true){
            kursibundar.SetActive(false);
        }
            
        else{
            kursibundar.SetActive(true);
        }  
    }

    public void Meja(){
        if (meja.activeInHierarchy == true){
            meja.SetActive(false);
        }
            
        else{
            meja.SetActive(true);
        }  
    }

    public void Meja3(){
        if (meja3.activeInHierarchy == true){
            meja3.SetActive(false);
        }
            
        else{
            meja3.SetActive(true);
        }  
    }

    public void Meja4(){
        if (meja4.activeInHierarchy == true){
            meja4.SetActive(false);
        }
            
        else{
            meja4.SetActive(true);
        }  
    }
    public void Rak(){
        if (rak.activeInHierarchy == true){
            rak.SetActive(false);
        }
            
        else{
            rak.SetActive(true);
        }  
    }

    public void Sofa(){
        if (sofa.activeInHierarchy == true){
            sofa.SetActive(false);
        }
            
        else{
            sofa.SetActive(true);
        }  
    }
    public void StandProdct1(){
        if (standproduct1.activeInHierarchy == true){
            standproduct1.SetActive(false);
        }
            
        else{
            standproduct1.SetActive(true);
        }

    }

    public void StandProdct2(){
        if (standproduct2.activeInHierarchy == true){
            standproduct2.SetActive(false);
        }
            
        else{
            standproduct2.SetActive(true);
        }  
    }
}
