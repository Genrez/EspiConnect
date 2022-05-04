using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookLeft : MonoBehaviour
{
    public Rigidbody2D robot;
    public Animator animator;
    void Awake()
    {
        StartCoroutine("LookA");
    }

    IEnumerator LookA() //Makes Robot Look Left
    {
        animator.SetFloat("Vertical", 0);
        animator.SetFloat("Horizontal", -1);
        yield return new WaitForSeconds(0f);
        StartCoroutine("LookA");
    }
}
