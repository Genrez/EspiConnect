using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour
{
    private bool playerInView = false;
    public GameObject robot;

    // Update is called once per frame
    void Update()
    {
        if (playerInView)
        {
            //Debug.Log(robot.name + " can see the player");
        }
    }

    public void IsPlayerInView(bool isInView)
    {
        playerInView = isInView;
    }
}
