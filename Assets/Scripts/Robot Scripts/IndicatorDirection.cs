using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndicatorDirection : MonoBehaviour
{
    public Rigidbody2D robot;
    public Animator animator;

    void Start()
    {
        
    }
    void Update()
    {
        if (animator.GetFloat("Vertical") == 0 && animator.GetFloat("Horizontal") == 1)
        {
            transform.eulerAngles = new Vector3(0f, 0f, 180f);
        }

        if (animator.GetFloat("Vertical") == -1 && animator.GetFloat("Horizontal") == 0)
        {
            transform.eulerAngles = new Vector3(0f, 0f, 90f);
        }

        if (animator.GetFloat("Vertical") == 1 && animator.GetFloat("Horizontal") == 0)
        {
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }

        if (animator.GetFloat("Vertical") == 0 && animator.GetFloat("Horizontal") == -1)
        {
            transform.eulerAngles = new Vector3(0f, 0f, 270f);
        }
    }
}
