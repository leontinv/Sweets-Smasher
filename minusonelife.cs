using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minusonelife : MonoBehaviour
{
    public GameObject particles;
    public GameObject plusfive;


    void OnTriggerEnter2D(Collider2D player)
    {
        if (player.CompareTag("player"))
        {
            Destroy(gameObject);
            Instantiate(particles, transform.position, Quaternion.identity);
            Instantiate(plusfive, transform.position, Quaternion.identity);

            
            


        }

        if(player.CompareTag("edge"))
        {
            lifescorescript.scoreLifeValue -= 1;
        }
    }

}
