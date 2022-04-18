using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTransform : MonoBehaviour
{
    private SpriteRenderer playerSpriteRenderer;
    private PlayerController playerController;

    private void Start()
    {
        playerSpriteRenderer = GetComponent<SpriteRenderer>();
        playerController = GetComponent<PlayerController>();
    }

    public void Transform(string robotName)
    {
        GameObject newRobot = GameObject.Find(robotName);
        GetComponent<Animator>().enabled = false;
        playerSpriteRenderer.sprite = newRobot.GetComponent<SpriteRenderer>().sprite;
        playerController.SetPlayerState(newRobot.name);

    }

    public void RevertTransform()
    {
        GetComponent<Animator>().enabled = true;
        playerController.SetPlayerState("Player");
    }
}
