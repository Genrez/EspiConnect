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
        detectionBar.SetInitialSlider(currentDetectionLevel);
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInView)
        {
            if (gameObject.name.Substring(0, 5) != playerController.GetPlayerState().Substring(0, 5))
            {
                IncreaseDetectionLevel();
            }
        }
        else if (!playerInView && currentDetectionLevel > 0)
        {
            DecreaseDetectionLevel(1.7f);
        }
        if (detectionBar.getSliderValue() >= 20)
        {
            gameoverScreen.gameObject.SetActive(true);
            AudioSource audio = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<AudioSource>();
            audio.enabled = false;
            AudioSource player = GameObject.FindGameObjectWithTag("Player").GetComponent<AudioSource>();
            player.enabled = false;
        }
    }

    private void IncreaseDetectionLevel()
    {
        currentDetectionLevel += Time.deltaTime;
        detectionBar.SetDetection(currentDetectionLevel);
    }

    private void DecreaseDetectionLevel(float amountToDecrease)
    {
        currentDetectionLevel -= Time.deltaTime;
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
