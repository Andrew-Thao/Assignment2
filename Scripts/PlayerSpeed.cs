using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSpeed : MonoBehaviour
{

    public Slider speedSlider;
    public Text speedText;

    void Start()
    {
        
    }
    public void SpeedControl()
    {
        PlayerController.speed = speedSlider.value;
        speedText.text = speedSlider.value.ToString();
    }
    
}
