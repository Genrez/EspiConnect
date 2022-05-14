using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patroller : MonoBehaviour
{
    public Transform[] points;
    public float speed;
    int current;
    public Rigidbody2D robot;
    public Animator animator;

    void Start()
    {
        current = 0;  
    }

    void Update()
    {
        if (transform.position != points[current].position)
        {
            transform.position = Vector2.MoveTowards(transform.position, points[current].position, speed * Time.deltaTime);
        }
        else
        {
            current = (current + 1) % points.Length;
        }

        if (current == 0)
        {
            animator.SetFloat("Vertical", 0);
            animator.SetFloat("Horizontal", 1);
        }

        if (current == 1)
        {
            animator.SetFloat("Vertical", -1);
            animator.SetFloat("Horizontal", 0);
        }

        if (current == 2)
        {
            animator.SetFloat("Vertical", 0);
            animator.SetFloat("Horizontal", -1);
        }

        if (current == 3)
        {
            animator.SetFloat("Vertical", 1);
            animator.SetFloat("Horizontal", 0);
        }
    }


}
