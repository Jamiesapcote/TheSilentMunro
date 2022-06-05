using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{
    public float CurrentTime = 0f;
    public float startingTime = 10f;

    [SerializeField]Text CountDownText;

    private void Start()
    {
        CurrentTime = startingTime;

    }
    private void Update()
    {
        CurrentTime -= 1 * Time.deltaTime;
        CountDownText.text = CurrentTime.ToString("0");

        if (CurrentTime <= 0)
        {
            CurrentTime = 0;
        }
    }
}
