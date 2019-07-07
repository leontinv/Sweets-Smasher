using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyer : MonoBehaviour
{
    public float destroytime = 2f;
    void Start()
    {
        Destroy(gameObject, destroytime);
    }

}
