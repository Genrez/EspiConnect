using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAround : MonoBehaviour
{
    public Rigidbody2D robot;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {
        StartCoroutine("LookA");
    }

    IEnumerator LookA() //Makes Robot Look Right (0,1) before switching to LookB 2 seconds
    {
       animator.SetFloat("Vertical", 0);
       animator.SetFloat("Horizontal", 1);
       yield return new WaitForSeconds(2f);
        StartCoroutine("LookB");
    }

    IEnumerator LookB() //Makes Robot Look Down (-1,0) before switching to LookA 2 seconds
    {
        animator.SetFloat("Vertical", -1);
        animator.SetFloat("Horizontal", 0);
        yield return new WaitForSeconds(2f);
        StartCoroutine("LookA");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
