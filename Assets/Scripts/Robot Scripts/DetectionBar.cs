using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectionBar : MonoBehaviour
{
    public Slider slider;

    public void SetDetection(float sliderValue)
    {
        slider.value = Mathf.Lerp(0, 400, sliderValue / 5);
    }

    public void SetMaxDetection(int max)
    {
        slider.maxValue = max;
        slider.value = 0;
    }

    public void SetInitialSlider(float sliderValue)
    {
        slider.value = sliderValue;
    }

    public float getSliderValue()
    {
        return slider.value;
    }
}
