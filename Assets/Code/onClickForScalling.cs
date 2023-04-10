using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onClickForScalling : MonoBehaviour
{
    void OnMouseDown()
    {
        CSharpscaling.ScaleTransform = this.transform;
    }
}
