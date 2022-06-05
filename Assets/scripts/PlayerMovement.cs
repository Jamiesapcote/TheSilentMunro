using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed; // this is for move speed 
    public Rigidbody2D rb; // this is for rb 
    private Vector2 moveDirection; // this is a varable for move direction 
    public Animator animator;
    private float boostTimer; // how long the boos has been actavated and when to deactivate this 
    private bool boosting; // is the power up active or not this is set by true or false 
    private  float moveSpeedOriginal;

    public ProjectileBehavior ProjectilePrefab;
    public Transform LaunchOffset; 
    private void Start()
    {
        moveSpeedOriginal = moveSpeed;
        boostTimer = 0; // this is setting th boost timer to 0 when the game starts 
        boosting = false; // boosing when the game starts is false untill player collides with the object then it will becouse true 
    }

    void Update()
    {
        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
        
        if (boosting)
        {
            boostTimer += Time.deltaTime;
            if (boostTimer >= 30) // this is for when to turn off the boost and adding to the timer 
            {
                moveSpeed = moveSpeedOriginal;
                boostTimer = 0;
                boosting = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            Instantiate(ProjectilePrefab, LaunchOffset.position, transform.rotation);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) // this is whem the player collides with the object 
    {
        if (other.tag == "speedBoost")// this is seeing if we have collided with the object if so then setting the values to be boosing/true 
        {
            boosting = true;
            moveSpeed = 5;
            Destroy(other.gameObject);
        }
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
