using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour
{
    public bool playerInView = false;
    private PlayerController playerController;
    private AwarenessBar awarenessBar;

    //This method is called at the start
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        awarenessBar = GameObject.Find("AwarenessBar").GetComponent<AwarenessBar>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInView)
        {
            if (gameObject.name != playerController.GetPlayerState())
            {
                awarenessBar.awareness.IncreaseAwarenessBar();
            }
        }
        else if (!playerInView)
        {
            awarenessBar.awareness.DecreaseAwarenessBar();
        }
    }

    public void SetPlayerInView(bool isInView)
    {
        playerInView = isInView;
    }
}
