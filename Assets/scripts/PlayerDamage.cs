using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        if (otherCollider.CompareTag("enemy") == true)
        {
            KillEnemy(otherCollider.gameObject);
        }
    }
    public void KillEnemy(GameObject Enemy)
    {
        //check if the enemy  has the "scoreKill" companant 
        ScoreKill scoreKillScript = Enemy.GetComponent<ScoreKill>();
        if (scoreKillScript != null)
        {
            //this means our enemy has a score value 
            Score playerScore = FindObjectOfType<Score>();

            //add the value from the scoreKill script 
            playerScore.AddScore(scoreKillScript.KillValue);

           
        }




        Destroy(Enemy);
    }
}
