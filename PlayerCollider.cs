using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerCollider : MonoBehaviour
{
   
    public GameObject particles;
    public GameObject plusfive;
   
    

    void Start()
    {
       
    }
   
   void OnTriggerEnter2D (Collider2D player)
    {
        if (player.CompareTag("player"))
        {
            Destroy(gameObject);
            Instantiate(particles, transform.position, Quaternion.identity);
            Instantiate(plusfive, transform.position, Quaternion.identity);
           
            ScoreScript.scoreValue += 5;
            SliderAdd.sliderValue.value += 5f;
            
           
        }
     /*   else
        if (player.CompareTag("edge"))
        {
            SceneManager.LoadScene("SampleScene");
        }*/

    }

    
  
}
