using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookUp : MonoBehaviour
{
    public Rigidbody2D robot;
    public Animator animator;
    void Awake()
    {
        StartCoroutine("LookA");
    }

    IEnumerator LookA() //Makes Robot Look Up
    {
        animator.SetFloat("Vertical", 1);
        animator.SetFloat("Horizontal", 0);
        yield return new WaitForSeconds(0f);
        StartCoroutine("LookA");
    }
}
