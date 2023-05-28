using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class slider_script : MonoBehaviour
{
   public Slider slider;
   public TextMeshProUGUI sliderValue;

   void Start()
   {
      
   }

   void Update()
   {
      sliderValue.text = slider.value.ToString("0.00");
   }
}
