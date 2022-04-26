using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionScript : MonoBehaviour
{
    private CapsuleCollider2D capsuleCollider;
    private PolygonCollider2D polygonCollider;
    private BoxCollider2D playerCollider;
    public RobotController robotcontroller;
    private PolygonCollider2D edgeCollider1;
    private PolygonCollider2D edgeCollider2;

    void Start()
    {
        playerCollider = GameObject.Find("Player").GetComponent<BoxCollider2D>();
        capsuleCollider = GetComponent<CapsuleCollider2D>();
        edgeCollider1 = GetComponent<PolygonCollider2D>();
        edgeCollider2 = GetComponent<PolygonCollider2D>();
        polygonCollider = GetComponent<PolygonCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (capsuleCollider.IsTouching(playerCollider) || polygonCollider.IsTouching(playerCollider) || edgeCollider1.IsTouching(playerCollider) || edgeCollider2.IsTouching(playerCollider)) {
            robotcontroller.SetPlayerInView(true);
        }
        else {
            robotcontroller.SetPlayerInView(false);
        }
    }
}
