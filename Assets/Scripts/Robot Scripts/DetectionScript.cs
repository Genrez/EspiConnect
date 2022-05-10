using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionScript : MonoBehaviour
{
    public RobotController robotcontroller;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
            robotcontroller.SetPlayerInView(true);


        }
    }
        private void OnTriggerExit2D(Collider2D collision)
        {


            if (collision.CompareTag("Player"))
            {
                robotcontroller.SetPlayerInView(false);
            }
        }
    
}
