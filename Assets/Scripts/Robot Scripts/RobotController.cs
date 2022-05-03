using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour
{
    public bool playerInView = false;
    public bool robotVision = false;
    private PlayerController playerController;
    private AwarenessBar awarenessBar;
    public string robotType;

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
                Debug.Log("In view");
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
        if (robotVision)
        { playerInView = isInView;  }
        else
        { playerInView = false; }


    }
    public void SetRobotVision(bool vison)
    {
        robotVision = vison;
    }
}
