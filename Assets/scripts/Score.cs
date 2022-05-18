using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //public varalbes 
    public Text scoreDisplay;

    //private varables 
    private int scoreValue = 0;

    public void AddScore(int toAdd)
    {
        // update the numerical value of the score (action 1)
        scoreValue = scoreValue + toAdd;

        //Update the display of the score based on the numerical 
        scoreDisplay.text = scoreValue.ToString();
    }
   
}
