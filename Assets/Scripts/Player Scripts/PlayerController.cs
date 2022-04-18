using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private string robotTouching = "";
    private string playerState = "Player"; 
    private PlayerTransform playerTransform;

    void Start()
    {
        playerTransform = GetComponent<PlayerTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (robotTouching != "" && Input.GetKeyDown(KeyCode.E)) {
            playerTransform.Transform(robotTouching);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            playerTransform.RevertTransform();
        }
    }

    public void SetRobotTouching(string robot)
    {
        robotTouching = robot;
    }

    public void SetPlayerState(string playerState)
    {
        this.playerState = playerState;
    }

    public string GetPlayerState()
    {
        return playerState;
    }
}
