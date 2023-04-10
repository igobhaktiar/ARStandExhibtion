using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiObjectRotation : MonoBehaviour
{
    private Vector2 lastTouchPos;
    private GameObject objectToRotate;

    // Array untuk menampung objek yang akan diputar
    public GameObject[] objectsToRotate;

    // Kecepatan putaran objek
    public float rotationSpeed = 1.0f;

    private void Update()
    {
        // Deteksi input sentuh 

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(1);
            
            if (touch.phase == TouchPhase.Began)
            
            {
                // Menentukan objek yang akan diputar
                
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit;
               
                if (Physics.Raycast(ray, out hit))
                {
                    for (int i = 0; i < objectsToRotate.Length; i++)
                    {
                        if (hit.transform.gameObject == objectsToRotate[i])
                        {
                            objectToRotate = objectsToRotate[i];
                            break;
                        }
                    }
                }
            }
            
            else if (touch.phase == TouchPhase.Moved && objectToRotate != null)
            
            {
                // Memperoleh posisi sentuhan terakhir dan saat ini
                Vector2 touchDelta = touch.deltaPosition;
                lastTouchPos += touchDelta;

                // Memutar objek yang dipilih
                objectToRotate.transform.Rotate(Vector3.up * -touchDelta.x * rotationSpeed, Space.World);
           
            }
             
            else if (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled)
            {
            // Melepaskan objek yang diputar
            objectToRotate = null;
            }
        }
    }
    
}
