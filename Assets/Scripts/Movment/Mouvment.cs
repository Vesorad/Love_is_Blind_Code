using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouvment : MonoBehaviour
{
    public float power;
    public float speed;
    public Rigidbody2D RB;

    public MouvmentPlayer2 mouvmentPlayer2;
    public GroundCheck groundCheck;

    public Animator animator;
    float horizontalMovment;

    
    public void Start()
    {

        RB = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (mouvmentPlayer2.HasMovment == true)
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
         horizontalMovment = Input.GetAxis("Debug Horizontal");
        Vector3 movment = new Vector3(Input.GetAxis("Debug Horizontal"), 0, 0);
        animator.SetFloat("Speed", Mathf.Abs(horizontalMovment));
        //transform.Translate(horizontalMovment * Time.deltaTime, 0, 0);
        transform.position += movment * speed * Time.deltaTime;
        if (horizontalMovment <0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
       
       

        if (Input.GetKeyDown(KeyCode.UpArrow))
       {
            if (groundCheck.jump == false)
            {
                animator.SetBool("Jump", true);  
                RB.AddForce(transform.up * power, ForceMode2D.Impulse);
                groundCheck.jump = true;
                
            }
            
       }
    }
    
}

