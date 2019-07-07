using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextDestroyer : MonoBehaviour
{
    private float destroytime = 1f;

    void Start()
    {
        Destroy(gameObject, destroytime);
    }

    
}
