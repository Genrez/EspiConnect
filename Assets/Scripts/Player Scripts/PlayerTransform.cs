using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTransform : MonoBehaviour
{
    private SpriteRenderer playerSpriteRenderer;
    private PlayerController playerController;
    private RuntimeAnimatorController originalAnimatorController;

    private void Start()
    {
        playerSpriteRenderer = GetComponent<SpriteRenderer>();
        playerController = GetComponent<PlayerController>();
        originalAnimatorController = GetComponent<Animator>().runtimeAnimatorController;
    }

    public void Transform(string robotName)
    {
        GameObject newRobot = GameObject.Find(robotName);
        GetComponent<Animator>().runtimeAnimatorController = newRobot.GetComponent<Animator>().runtimeAnimatorController;
        playerSpriteRenderer.sprite = newRobot.GetComponent<SpriteRenderer>().sprite;
        playerController.SetPlayerState(newRobot.name);

    }

    public void RevertTransform()
    {
        GetComponent<Animator>().runtimeAnimatorController = originalAnimatorController;
        playerController.SetPlayerState("Player");
    }
}
