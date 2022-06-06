using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{
    public float CurrentTime = 0f;
    public float startingTime = 10f;
    private bool AddTime; // is the power up active or not this is set by true or false 

    [SerializeField]Text CountDownText;

    private void Start()
    {
        CurrentTime = startingTime;

    }
    private void Update()
    {
        if (AddTime)
        {

            if (CurrentTime <= -2000) // this is for when to turn off the boost and adding to the timer 
            {
                CurrentTime = startingTime;
                AddTime = false;
            }
        }



        CurrentTime -= 1 * Time.deltaTime;
        CountDownText.text = CurrentTime.ToString("0");

        if (CurrentTime <= 0)
        {
            CurrentTime = 0;
        }
    }
    private void OnTriggerEnter2D(Collider2D other) // this is whem the player collides with the object 
    {
        if (other.tag == "AddTime")// this is seeing if we have collided with the object if so then setting the values to be boosing/true 
        {
            AddTime = true;
            CurrentTime = 20;
            Destroy(other.gameObject);
        }
    }
}
