using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] enemy;
    public GameObject bomba;
  
    public float startSpawn;
    private float timeBTspawns;
   // private float timeleft = 30f;
    private bool eBomba = false;
 
    private int randomNumber;


    
 private void Update()
    {
        //timeleft -= Time.deltaTime;
       /* if(timeleft <= 0)
        {
            gameObject.SetActive(false);
        } */

       if ((ScoreScript.scoreValue > 100) && (ScoreScript.scoreValue < 500))
        {
            startSpawn = 0.5f;
        }
       else if(ScoreScript.scoreValue >500)
        {
            startSpawn = 0.25f;
        }

        if (timeBTspawns < 0)
        {
            if ( randomEnemy() == 1 )
            {
                eBomba = true;
            }
            else
            {
                eBomba = false;
            }

        


            if (eBomba == false)
            {
                Instantiate(enemy[Random.Range(0, enemy.Length)], transform.position, Quaternion.identity);
            }
            else
                if(eBomba)
            {
                Instantiate(bomba, transform.position, Quaternion.identity);
            }
           
        

            

            timeBTspawns = startSpawn;
        }
        else
        {
            timeBTspawns -= Time.deltaTime;
        }
    }


    private int randomEnemy()
    {
        randomNumber = Random.Range(1, 30);
        return randomNumber;
    }
}
