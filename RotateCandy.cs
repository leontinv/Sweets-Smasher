using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCandy : MonoBehaviour
{

    public GameObject image;

 
    void Update()
    {
        image.transform.Rotate(0f, 0f, 0.5f);
    }
}
