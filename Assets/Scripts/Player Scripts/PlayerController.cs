using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public ParticleSystem hack;
    private string robotTouching = "";
    private string playerState = "Player"; 
    private PlayerTransform playerTransform;
    private Scene currentScene;

    void Start()
    {
        playerTransform = GetComponent<PlayerTransform>();
        currentScene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
        if (robotTouching != "" && Input.GetKeyDown(KeyCode.E)) {
            hack.Play();
            playerTransform.Transform(robotTouching);
        }
        if (robotTouching != "" && Input.GetKeyDown(KeyCode.F) && currentScene.name == "Level4")
        {
            RobotController robotToDisable = GameObject.Find(robotTouching).GetComponent<RobotController>();
            robotToDisable.DisableRobot();
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            hack.Play();
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
