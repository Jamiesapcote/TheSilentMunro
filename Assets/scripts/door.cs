using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class door : MonoBehaviour
{
    public string levelToLoad;

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {

        if (otherCollider.tag == "Players")
        {
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
