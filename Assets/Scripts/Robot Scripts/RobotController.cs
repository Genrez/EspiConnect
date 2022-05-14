using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour
{
    public bool playerInView = false;
    private PlayerController playerController;
    public DetectionBar detectionBar;
    public GameOverScreen gameoverScreen;
    public GameObject detectionIndicator;

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
            if (gameObject.name.Substring(0, 5) != playerController.GetPlayerState().Substring(0, 5))
            {
                IncreaseDetectionLevel(0.4f);
            }
        }
        else if (!playerInView && currentDetectionLevel > 0)
        {
            DecreaseDetectionLevel(0.4f);
        }
        if (currentDetectionLevel >= 20)
        {
            gameoverScreen.gameObject.SetActive(true);
            AudioSource audio = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<AudioSource>();
            audio.enabled = false;
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

    public void DisableRobot()
    {
        detectionIndicator.SetActive(false);
    }
}
