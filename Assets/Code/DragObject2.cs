using UnityEngine;
using System.Collections;

public class DragObject2 : MonoBehaviour
{

    Vector3 dist;
    float posX;
    float posY;
    float objectHeight = 0f; // tinggi objek di atas ground plane

    void OnMouseDown()
    {
        if (Input.touchCount == 1)
        {
            dist = Camera.main.WorldToScreenPoint(transform.position);
            posX = Input.touches[0].position.x - dist.x;
            posY = Input.touches[0].position.y - dist.y;
        }
        
    }

    void OnMouseDrag()
    {
        if (Input.touchCount == 1) {
        Vector3 curPos =
        new Vector3(Input.touches[0].position.x - posX,
        Input.touches[0].position.y - posY, dist.z);

        Vector3 worldPos = Camera.main.ScreenToWorldPoint(curPos);
        // worldPos.z = 0f; // posisi z objek selalu di ground plane
        worldPos.y = objectHeight; // ketinggian objek di atas ground plane
        transform.position = worldPos;
        }
    }
}