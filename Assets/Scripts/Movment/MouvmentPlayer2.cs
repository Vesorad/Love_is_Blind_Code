using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvmentPlayer2 : MonoBehaviour
{
    public float power;
    public float speed;

    public bool HasMovment = true;
    public Rigidbody2D rb;

    public GroundCheck groundCheck;
    private float horizontalMovment;

    public Animator animator;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void Update()
    {
        if (HasMovment == true)
        {
            MouvmentPlayer();
        }
        else
        {
            
            animator.SetBool("Win", true);
        }
        
    }
    private void MouvmentPlayer()
    {
        horizontalMovment = Input.GetAxis("Horizontal") * speed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMovment));
        transform.Translate(horizontalMovment * Time.deltaTime, 0, 0);
        if (horizontalMovment < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            if (groundCheck.jump == false)
            {
                animator.SetBool("Jump", true);
                rb.AddForce(transform.up * power, ForceMode2D.Impulse);
                groundCheck.jump = true;
                
            }
            
        }
    }

    
}
