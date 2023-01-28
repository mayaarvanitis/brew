using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerScript50 : MonoBehaviour
{

    public float  timeValue = 3000;
    public Text timeText;


    // Update is called once per frame
    void Update()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
        }
        DisplayTime(timeValue);        

    }

    // function to display the time on screen in minutes and seconds!
    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        //if less than 0, make it 0 to avoid glitch!
        {
            timeToDisplay = 0;
        }
        
        // minutes : seconds/60, rounded down
        float minutes = Mathf.FloorToInt(timeToDisplay/60);
        // seconds : use modulo to get remainder after dividing by 60 
        float seconds = Mathf.FloorToInt(timeToDisplay%60);


        // now to display minutes and seconds : 
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);



    }
}
