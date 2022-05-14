using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowThePath : MonoBehaviour
{
    public Rigidbody2D robot;
    public Animator animator;
    public int speed = 15;
    private bool done = false;
    [SerializeField]
    public Vector3 target;
    public Vector3 target2;
    void Awake()
    {

    }

    IEnumerator LookA() //Makes Robot Look Down
    {
        animator.SetFloat("Vertical", 1);
        animator.SetFloat("Horizontal", 0);
        var step = speed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, target, step);
        yield return new WaitForSeconds(999999999999f);
    }

    IEnumerator LookB() //Makes Robot Look Up
    {
        animator.SetFloat("Vertical", -1);
        animator.SetFloat("Horizontal", 0);
        var step = speed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, target2, step);
        yield return new WaitForSeconds(9999999999999f);
    }

    private void Update()
    {
        if (done == false)
        {
            StartCoroutine("LookA");
        }

        if (done == true)
        {

            StartCoroutine("LookB");
        }

        if (transform.position == target)
        {
            done = true;
        }
        if (transform.position == target2)
        {
            done = false;
        }


    }
}