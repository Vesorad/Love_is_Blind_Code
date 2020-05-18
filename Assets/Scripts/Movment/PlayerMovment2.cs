using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment2 : MonoBehaviour
{
    public CharacterController2D characterController;
    public Animator animator;


    float horizontalMove = 0f;
    public float runSpeed = 40f;

    public bool HasMovment = true;
    public bool jump = false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (HasMovment == true)
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
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        if (Input.GetKeyDown(KeyCode.W))
        {
            jump = true;
            animator.SetBool("Jump", true);
        }
    }

    private void FixedUpdate()
    {
        characterController.Move(horizontalMove * Time.deltaTime, false, jump);
        jump = false;

    }
    public void OnLanding()
    {
        animator.SetBool("Jump", false);
    }
}
