using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookLeftUp : MonoBehaviour
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
        yield return new WaitForSeconds(2f);
        StartCoroutine("LookB");
    }

    IEnumerator LookB() //Makes Robot Look Up
    {
        animator.SetFloat("Vertical", 1);
        animator.SetFloat("Horizontal", 0);
        yield return new WaitForSeconds(2f);
        StartCoroutine("LookA");
    }
}
