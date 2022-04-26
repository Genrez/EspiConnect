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

    IEnumerator LookA()
    {
       animator.SetFloat("Vertical", 0);
       animator.SetFloat("Horizontal", 1);
       yield return new WaitForSeconds(2f);
        StartCoroutine("LookB");
    }

    IEnumerator LookB()
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
