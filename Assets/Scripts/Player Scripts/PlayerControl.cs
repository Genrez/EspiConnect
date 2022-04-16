using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float interpSpeed;
    public Animator animator;
    public float speed;
    private Vector3 targetPos;

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Magnitude", movement.magnitude);
        transform.position = transform.position + movement * speed;

        if (GetComponent<Rigidbody2D>().velocity.magnitude >= 0.001)
        {
            if (!GetComponent<AudioSource>().isPlaying)
            {
                
            }
        }


    }

}
