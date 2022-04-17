using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerController playerController;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Robot"))
        {
            playerController.SetRobotTouching(collision.collider.name);
        }
    }

    private void OnCollisionExit2D()
    {
        playerController.SetRobotTouching("");
    }
}
