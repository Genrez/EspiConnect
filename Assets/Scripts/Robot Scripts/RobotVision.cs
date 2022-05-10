using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotVision : MonoBehaviour
{
    // Start is called before the first frame update
    public RobotController robotcontroller;
    
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(robotcontroller.robotType == "Light")
        {
            if (collision.CompareTag("Light"))
            {
                robotcontroller.SetRobotVision(true);
            }
        }
        if (robotcontroller.robotType == "Night")
        {
            if (!collision.CompareTag("Light"))
            {
                robotcontroller.SetRobotVision(true);
            }
        }
        


    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (robotcontroller.robotType == "Light")
        {
            if (collision.CompareTag("Light"))
            {
                robotcontroller.SetRobotVision(false);
            }
        }
        if (robotcontroller.robotType == "Night")
        {
            if (!collision.CompareTag("Light"))
            {
                robotcontroller.SetRobotVision(false);
            }
        }
    }
}
