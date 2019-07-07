﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerExplosion : MonoBehaviour
{
    public GameObject explosion;

    void OnTriggerEnter2D(Collider2D bomba)
    {
        if(bomba.CompareTag( "player"))
        {
            Instantiate(explosion, transform.position, Quaternion.identity);
        }
    }


}
