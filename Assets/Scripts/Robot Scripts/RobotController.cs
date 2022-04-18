using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour
{
    private bool playerInView = false;
    private PlayerController playerController;

    //This method is called at the start
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInView)
        {
            if (gameObject.name != playerController.getPlayerState())
            {
                Debug.Log(gameObject.name + " found the player.");
            }

        }
    }

    public void IsPlayerInView(bool isInView)
    {
        playerInView = isInView;
    }
}
