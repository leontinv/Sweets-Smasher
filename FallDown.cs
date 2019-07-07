using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDown : MonoBehaviour
{
    public float speed;
    
  
    void Update()
    {
        if ((ScoreScript.scoreValue > 100) && (ScoreScript.scoreValue < 500))
        {
            speed = 2;
        }
        else if(ScoreScript.scoreValue > 500)
        {
            speed = 3;
        }
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }
}
