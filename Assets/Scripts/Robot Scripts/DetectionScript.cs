using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionScript : MonoBehaviour
{
    private CapsuleCollider2D capsuleCollider;
    private PolygonCollider2D polygonCollider;
    private BoxCollider2D playerCollider;
    public RobotController robotcontroller;

    void Start()
    {
        playerCollider = GameObject.Find("Player").GetComponent<BoxCollider2D>();
        capsuleCollider = GetComponent<CapsuleCollider2D>();
        polygonCollider = GetComponent<PolygonCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (capsuleCollider.IsTouching(playerCollider) || polygonCollider.IsTouching(playerCollider)) {
            robotcontroller.IsPlayerInView(true);
        }
        else {
            robotcontroller.IsPlayerInView(false);
        }
    }
}
