using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeLimit : MonoBehaviour
{
    public float timeLimit;
    public string gameOverScene;

    private float startTime;
    private Text timeDisplay;
    // Start is called before the first frame update
    void Start()
    {
        timeDisplay = GetComponent<Text>();
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float timePassed = Time.time - startTime;

        timeDisplay.text = (Mathf.CeilToInt(timeLimit - timePassed)).ToString();

        if(timePassed >= timeLimit)
        {
            SceneManager.LoadScene(gameOverScene);
        }
    }
}
