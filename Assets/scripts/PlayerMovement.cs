using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed; // this is for move speed 
    public Rigidbody2D rb; // this is for rb 
    private Vector2 moveDirection; // this is a varable for move direction 
    public Animator animator;

    void Update()
    {
        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
    }
    void FixedUpdate()
    {
        //Phiysics calculations 
        processInputs();
        move();

    }
    //this is for the inputs for movment 
    void processInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveDirection = new Vector2(moveX, moveY).normalized;

    }


    void move()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }
}
