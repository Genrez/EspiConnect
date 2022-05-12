using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookDownUp : MonoBehaviour
{
    public Rigidbody2D robot;
    public Animator animator;
    private int speed = 5;
    void Awake()
    {
        StartCoroutine("LookA");
    }

    IEnumerator LookA() //Makes Robot Look Down
    {
        animator.SetFloat("Vertical", -1);
        animator.SetFloat("Horizontal", 0);
        yield return new WaitForSeconds(1.5f);
        StartCoroutine("LookB");
    }

    IEnumerator LookB() //Makes Robot Look Up
    {
        animator.SetFloat("Vertical", 1);
        animator.SetFloat("Horizontal", 0);
        yield return new WaitForSeconds(1.5f);
        StartCoroutine("LookA");
    }

 
}
