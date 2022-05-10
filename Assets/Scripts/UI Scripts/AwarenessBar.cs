using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AwarenessBar : MonoBehaviour
{
    public Awareness awareness;
    private Image barImage;
    public GameObject gameOverObject;
    
    private void Awake()
    {
        barImage = transform.Find("bar").GetComponent<Image>();
        awareness = new Awareness();
    }

    private void Update()
    {
        //awareness.Update();

        barImage.fillAmount = awareness.GetAwarenessNormalized();
        if (barImage.fillAmount == 1)
        {
            gameOverObject.SetActive(true);
        }
    }
}

public class Awareness
{
    public const int Awareness_MAX = 100;

    private float awarnessAmount;
    private float awarnessRegenAmount;

    public Awareness()
    {
        awarnessAmount = 0;
        awarnessRegenAmount = 20f;
    }

    public void IncreaseAwarenessBar()
    {
        awarnessAmount += awarnessRegenAmount * Time.deltaTime;
    }

    public void DecreaseAwarenessBar()
    {
        if (awarnessAmount > 0)
        {
            awarnessAmount -= awarnessRegenAmount * Time.deltaTime;
        }
    }

    public float GetAwarenessNormalized()
    {
        return awarnessAmount / Awareness_MAX;
    }
}