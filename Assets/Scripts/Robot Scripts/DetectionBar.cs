using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectionBar : MonoBehaviour
{
    public Slider slider;

    public void SetDetection(float sliderValue)
    {
        slider.value = sliderValue;
    }

    public void SetMaxDetection(int max)
    {
        slider.maxValue = max;
        slider.value = 0;
    }
}
