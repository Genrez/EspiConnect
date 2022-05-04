using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookRight : MonoBehaviour
{
    public Rigidbody2D robot;
    public Animator animator;
    void Awake()
    {
        StartCoroutine("LookA");
    }

    IEnumerator LookA() //Makes Robot Look Right
    {
        animator.SetFloat("Vertical", 0);
        animator.SetFloat("Horizontal", 1);
        yield return new WaitForSeconds(0f);
        StartCoroutine("LookA");
    }
}
