using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public CharacterController2D characterController;
    public Animator animator;
    public PlayerMovment2 playerMovment;


    float horizontalMove = 0f;
    public float runSpeed = 40f;

    bool jump = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerMovment.HasMovment == true)
        {
            Movment();
        }
        else
        {
            horizontalMove = 0;
            animator.SetBool("Win", true);        
        }
        
    }

    private void Movment()
    {
        horizontalMove = Input.GetAxisRaw("Debug Horizontal") * runSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            jump = true;
            animator.SetBool("Jump", true);
        }
    }

    private void FixedUpdate()
    {
        characterController.Move(horizontalMove* Time.deltaTime,false, jump);
        jump = false;
        
    }
    public void OnLanding()
    {
        animator.SetBool("Jump", false);
    }
}
