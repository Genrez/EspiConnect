using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private string robotTouching = "";
    public PlayerTransform playerTransform;

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
}
