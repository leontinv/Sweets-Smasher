using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class CountDownScrippt : MonoBehaviour
{
    GameObject[] gameObjects;
    private float timeLeft = 30f;
    private TMP_Text timer;

    void Start()
    {
        timer = GetComponent<TMP_Text>();
    }

    
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if(timeLeft >= 0)
        {
            timer.text = "" + Mathf.Round(timeLeft);
        }

        else
        if (timeLeft < 0)
        {
            timer.text = "0";
            Invoke("TimeEnded", 2f);
            DestroyAllObjects();
        }
        
    }

    void TimeEnded()
    {
        SceneManager.LoadScene(0);
    }

    void DestroyAllObjects()
    {
        gameObjects = GameObject.FindGameObjectsWithTag("enemy");

        for (var i = 0; i < gameObjects.Length; i++)
        {
            Destroy(gameObjects[i]);
        }
    }
}
