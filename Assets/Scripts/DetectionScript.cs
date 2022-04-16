using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionScript : MonoBehaviour
{
    public CapsuleCollider2D capsuleCollider;
    public PolygonCollider2D polygonCollider;
    public BoxCollider2D playerCollider;
    public RobotController robotcontroller;

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
