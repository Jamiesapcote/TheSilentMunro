using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //public varalbes 
    public Text scoreDisplay;
    public bool shouldReset = false;

    //private varables 
    private static int scoreValue = 0;


    private void Start()
    {
        //check if we should be reseting the score this scene
        if (shouldReset == true)
        {
            //reset the score value back to 0
            scoreValue = 0;
        }


        //Update the display of the score based on the numerical value 
        scoreDisplay.text = scoreValue.ToString();

    }

    public void AddScore(int toAdd)
    {
        // update the numerical value of the score (action 1)
        scoreValue = scoreValue + toAdd;

        //Update the display of the score based on the numerical 
        scoreDisplay.text = scoreValue.ToString();
    }
   
}
