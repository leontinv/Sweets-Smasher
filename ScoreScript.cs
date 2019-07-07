using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    public static int scoreValue = 0;
    private int scoreincrease = 1;
    private TMP_Text score;
 
    void Start()
    {
        InvokeRepeating("ScoreIncrease", 0.5f, 0.5f);
        score = GetComponent<TMP_Text>();
        scoreValue = 0;
    }
    
    void ScoreIncrease()
    {
        scoreValue += scoreincrease;
    }
    void Update()
    {
        score.text = "" + scoreValue;
    }
}
