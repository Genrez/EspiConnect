using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpDown : MonoBehaviour
{
    public Rigidbody2D robot;
    public Animator animator;
    public int speed = 15;
    private bool done = false;
    void Awake()
    {

    }

    IEnumerator LookA() //Makes Robot Look Down
    {
        animator.SetFloat("Vertical", -1);
        animator.SetFloat("Horizontal", 0);
        Vector3 target = new Vector2(-51.01f, -77.7f);
        var step = speed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, target, step);
        yield return new WaitForSeconds(999999999999f);
    }

    IEnumerator LookB() //Makes Robot Look Up
    {
        animator.SetFloat("Vertical", 1);
        animator.SetFloat("Horizontal", 0);
        Vector3 target2 = new Vector2(-51.0f, -8.5f);
        var step = speed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, target2, step);
        yield return new WaitForSeconds(9999999999999f);
    }

    private void Update()
    {
        /*
        Vector3 target = new Vector2(-51.01f, -67.7f);
        Vector3 target2 = new Vector2(-51.0f, -8.5f);
        if (transform.position == target && done == true)
        {
            StopCoroutine("LookA");
            StartCoroutine("LookB");
            done = false;
        }
        if (transform.position != target2 && done == false)
        {
            StopCoroutine("LookB");
            StartCoroutine("LookA");
            done = true;
        }
        */
        Vector3 target = new Vector2(-51.01f, -77.7f);
        Vector3 target2 = new Vector2(-51.0f, -8.5f);

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
