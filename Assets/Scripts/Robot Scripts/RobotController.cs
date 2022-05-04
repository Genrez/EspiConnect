using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour
{
    public bool playerInView = false;
    private PlayerController playerController;
    public DetectionBar detectionBar;
    public GameOverScreen gameoverScreen;

    private float currentDetectionLevel = 0;


    //This method is called at the start
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        detectionBar.SetDetection(currentDetectionLevel);
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInView)
        {
            if (gameObject.name != playerController.GetPlayerState())
            {
                IncreaseDetectionLevel(0.2f);
            }
        }
        else if (!playerInView && currentDetectionLevel > 0)
        {
            DecreaseDetectionLevel(0.2f);
        }
        if (currentDetectionLevel >= 100)
        {
            gameoverScreen.gameObject.SetActive(true);
        }
    }

    private void IncreaseDetectionLevel(float amountToIncrease)
    {
        currentDetectionLevel += amountToIncrease;
        detectionBar.SetDetection(currentDetectionLevel);
    }

    private void DecreaseDetectionLevel(float amountToDecrease)
    {
        currentDetectionLevel -= amountToDecrease;
        detectionBar.SetDetection(currentDetectionLevel);
    }

    public void SetPlayerInView(bool isInView)
    {
        playerInView = isInView;
    }
}
