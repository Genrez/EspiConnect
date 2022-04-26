using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour
{
    public bool playerInView = false;
    private PlayerController playerController;
    public GameObject target;

    //This method is called at the start
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInView)
        {
            if (gameObject.name != playerController.GetPlayerState())
            {
                target.SetActive(true);
            }

        }
        //else
        //{
        //    target.SetActive(false);
        //}
        
    }

    public void SetPlayerInView(bool isInView)
    {
        playerInView = isInView;
    }
}
