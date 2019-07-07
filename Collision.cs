using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
    public GameObject sursaaudio;
    private bool ok = true;
    public GameObject minge;
    public GameObject trail;
  

    

    void OnTriggerEnter2D(Collider2D enemy)
    {

        if(enemy.CompareTag("enemy"))
        {
            Instantiate(sursaaudio, transform.position, Quaternion.identity);
        }

       

        if ((enemy.CompareTag("edge")) || (enemy.CompareTag("PlayGround")))
        {
            Invoke("Deratizare", 0.5f);
        }
        
       

    }


    

    void Deratizare()
    {
        Destroy(gameObject);
        GameObject ball = Instantiate(Resources.Load("Ball"), new Vector3(0.08f, -3.9f), Quaternion.identity) as GameObject;
        Instantiate(trail, new Vector3(0.08f, -3.9f), Quaternion.identity, ball.transform);
        ok = true;
    }

   
}
