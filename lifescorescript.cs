using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class lifescorescript : MonoBehaviour
{
    public static int scoreLifeValue = 3;
   
    private TMP_Text scoreLife;

    void Start()
    {
       
        scoreLife = GetComponent<TMP_Text>();
        scoreLifeValue = 3;
    }

    
    void Update()
    {
        scoreLife.text = "" + scoreLifeValue;
        EndGame();
    }

    void EndGame()
    {
        if(scoreLifeValue <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}

