using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePickUp : MonoBehaviour
{
    //public varable 
    public int pickupValue = 1;
    //called by unity when this object overlaps with another obejct marked as a trigger
    private void OnTriggerEnter2D(Collider2D other)
    {
        //check if the socre script is attached to the thing we bumped into 
        Score scoreScript = other.GetComponent<Score>();

        if (scoreScript != null)
        {
            // we have a  scoreScript, so the thing we bumped inot is the player

            // add our pick up value to the players current score (actions)
            scoreScript.AddScore(pickupValue);

            //we should then delete this object so we dont infinitely add score 
            Destroy(gameObject);

        }    
    }
}
