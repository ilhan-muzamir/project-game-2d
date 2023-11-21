using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEditor.Timeline.TimelinePlaybackControls;


public class Timer : MonoBehaviour
{
    public float timeRemaining = 0;
    public bool timeIsRunning = true;
    public TMP_Text timeText;
    public TMP_Text finalTimeText;

    void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("StartFlag"))
        {
            timeIsRunning = true;
        }
        else if (collision.gameObject.CompareTag("EndFlag"))
        {
            StopTime();
        }

    }

    void Update()
    {
        if (timeIsRunning)
        {
            if (timeRemaining >= 0)
            {
                timeRemaining += Time.deltaTime;
                DisplayTime(timeRemaining);
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
        finalTimeText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
    void StopTime()
    {
        timeIsRunning = false;
    }
    public float GetFinalTime()
    {
        return timeRemaining;
    }
}
