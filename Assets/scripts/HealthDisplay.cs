using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    //this will contain the silider comonant attached to this object 
    Slider healthBar;
    //this will be the players coponent that we can ask for 
    //indo about the players health 
    PlayerHealth player;


    // Start is called before the first frame update
    void Start()
    {
        //getting the slider companent off this game object 
        healthBar = GetComponent<Slider>();

        //search the intire scene for the player health component 
        // and store it in the player varable 
       player = FindObjectOfType<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        // create temporary float varables 
        //so we can use float division 
        float currentHealth = player.GetHealth();
        float maxHealth = player.startingHealth;

        //the slider value should be between 0 and 1 
        healthBar.value = currentHealth / maxHealth;
    }
}
