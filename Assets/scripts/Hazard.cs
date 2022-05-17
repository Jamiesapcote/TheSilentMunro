using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    //this will be the amount of damage the hazard does
    public int hazardDamage;


    //built in unity function for hadling collisions 
    //this function will be called when another object bumps
    //into the one this sipt is attached to
    void OnCollisionEnter2D(Collision2D CollisionData)
    {
        //get the object we collided with 
        Collider2D objectWeCollidedWith = CollisionData.collider;

        //Get the playehealth script attached to that object (if there is one)
        PlayerHealth player = objectWeCollidedWith.GetComponent<PlayerHealth>();
        //check if we actually found the player script on object we collided with
        // this if statment is true the player varable is NOT null (aka empty)
        if(player != null)
        {
            //this means there was a playerhealth script attached to the object we bumped into
            //which means this object is indead the player


            // therefore perform our acction
            player.changeHealth(-hazardDamage);
        }
    }
}

