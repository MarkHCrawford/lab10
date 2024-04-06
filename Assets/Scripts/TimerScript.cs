using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


/*****************************/
/* Mark Crawford             */
/* CSC 350H                  */
/* Professor Tang            */
/* Homework 6                */
/* Timer                     */
/* 03/12/2024                */
/******************************/


public class TimerScript : MonoBehaviour
{

    //Current time passed
    private float elapsedTime;
    //Time goal
    private float timeCounter;
    // When done
    private bool timerComplete;
    // Is moving?
    private bool timeMoving;

    public float ElapsedTime { get { return elapsedTime; } }
    public float TimeCounter { get { return timeCounter; } set { timeCounter = value; } }
    public bool TimerComplete { get { return timerComplete; } }

    public bool TimeMoving { get { return timeMoving; } }


    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTimer();
    }

    //Constructor
   public TimerScript()
    {
        this.timeCounter = 0;
        elapsedTime = 0;
        timerComplete = false;
        timeMoving = false;
    }



    // Set time moving
    public void StartTimer() 
    { 
        timeMoving = true; 
    }


    // For pausing timer
    public void StopTimer() 
    { 
        timeMoving = false; 
    }

    public void TimerReset() 
    { 
        elapsedTime = 0;
        timerComplete = false;
    }



    // Updating timer
    public void UpdateTimer()
    {
        if (!timerComplete && timeMoving)
        {
            elapsedTime += Time.deltaTime;
            if (elapsedTime >= timeCounter)
            {
                timerComplete = true;
            }
        }
        
    }


}
