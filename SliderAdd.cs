using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SliderAdd : MonoBehaviour
{
    public static Slider sliderValue;
    public GameObject bombitza;


    void Start()
    {
        sliderValue = GetComponent<Slider>();
        sliderValue.value = 0f;
    }


    void Update()
    {
        if (sliderValue.value == 500f)
            SpecialSkill();
    }
   void SpecialSkill()
    {
       
        {
            Instantiate(bombitza, new Vector3(0.081f, 0.1f), Quaternion.identity);
            sliderValue.value = 0f;
        }
    }
 
  
   
}
