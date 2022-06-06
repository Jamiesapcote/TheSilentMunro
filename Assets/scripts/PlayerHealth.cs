using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
   
    //this will be the starting health for the player
   public int startingHealth;
    public string gameOverScene;
    Animator animator;
    public Rigidbody2D rb;
    private bool addHealth; // is the power up active or not this is set by true or false 

    //this will be the players current health and will change during the game
    int currentHealth;


    private void Update()
    {
        if (addHealth)
        {
           
            if (currentHealth <= 100) // this is for when to turn off the boost and adding to the timer 
            {
                currentHealth = startingHealth;
                addHealth = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other) // this is whem the player collides with the object 
    {
        if (other.tag == "AddHealth")// this is seeing if we have collided with the object if so then setting the values to be boosing/true 
        {
            addHealth = true;
            currentHealth = 30;
            Destroy(other.gameObject);
        }
    }

    //built in fuction called when the scriot is created 
    //usally when the game starts
    void Awake()
    {
        //initialise our current health to be equal to our starting health
        currentHealth = startingHealth;
    }
    //this will change the player current health and kill them if they have 0 health or less
    public void changeHealth(int changeAmount)
    {
        currentHealth = currentHealth + changeAmount;
        //keep our health ,add the change amount and store
        //the result back in the current haelth variable 
        currentHealth = Mathf.Clamp(currentHealth, 0, startingHealth);

        //if our health  drops to 0, then the player should die 
        if (currentHealth == 0)
        {
            // we call the  kill function to kill the player 
            Kill();
            
        } 
    }


    //this function is Not built in to unity 
    // it will only be called manually by our own code 
    // it must be marked as !public" so our other scripts can access it 

    public void Kill()
    {
        //this will destroy the gameobject that this script is attached to
        Destroy(gameObject);


        //load the game over scene
        SceneManager.LoadScene(gameOverScene);
        
    }
    //it is a getter fucntion which gives info to the calling code 
    public int GetHealth()
    {
        //return will give the following info back to the calling code 
        return currentHealth;

    }
   
}
