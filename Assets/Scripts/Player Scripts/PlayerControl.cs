using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public ParticleSystem dust;
    //public float interpSpeed;
    public Rigidbody2D player;
    public Animator animator;
    public float speed;
    Vector2 movement;
    //private Vector3 targetPos;
    private float activeSpeed;
    public float dashSpeed;
    public float dashLength = .5f, dashCooldown = 1f;
    private float dashCounter;
    private float dashCoolCounter;


    void Start()
    {
        
        activeSpeed = speed;   
    }

    // Update is called once per frame
    void Update()
    {
        if (DialogueManager.isActive == true)
        {

            speed = 0;
                return;
        } else
        {
            speed = activeSpeed;
        }
            

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (movement != Vector2.zero)
        {
            animator.SetFloat("Horizontal", movement.x);
            animator.SetFloat("Vertical", movement.y);
        }
        animator.SetFloat("Magnitude", movement.sqrMagnitude);
        // transform.position = transform.position + movement * speed;
        AudioSource audio = GetComponent<AudioSource>();

        if (movement.magnitude >= 0.001 && !audio.isPlaying)
        {
               audio.Play();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (dashCoolCounter <=0 && dashCounter <=0)
            {
                speed = dashSpeed;
                dashCounter = dashLength;
            }
        }

        if (dashCounter > 0)
        {
            dashCounter -= Time.deltaTime;

            if (dashCounter <= 0)
            {
                speed = activeSpeed;
                dashCoolCounter = dashCooldown;
            }
        }

        if (dashCoolCounter > 0)
            {
                dashCoolCounter -= Time.deltaTime;
            }

        
    }

    void FixedUpdate()
    {
        player.MovePosition(player.position + movement * speed * Time.fixedDeltaTime);
        CreateDust();
    }

    void CreateDust()
    {
        dust.Play();
    }
}
