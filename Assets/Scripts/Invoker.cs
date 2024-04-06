using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


/**************************/
/* Mark Crawford          */
/* CSC 350H               */
/* Professor Tang         */
/* Lab 10, Invoker script */
/* 04/05/2024             */
/**************************/

public class Invoker : MonoBehaviour
{
    // Timer
    private TimerScript timer;
    // Event object
    private static MessageEvent newEvent;
    

    // Create event instance
    private void Awake()
    {
        // Instance of event
        if (newEvent == null)
            newEvent = new MessageEvent();
        
    }

    // start timer
    private void Start()
    {
        timer = gameObject.AddComponent<TimerScript>();
        timer.TimeCounter = 2;
        timer.StartTimer();
    }


    // Update timer and invoke event
    private void Update()
    {
        if (timer.TimerComplete)
        {
            newEvent.Invoke();
            timer.TimerReset();
            timer.StartTimer();
        }
    }

    
    // Event listener
    public void AddNoArgumentListener(UnityAction listener)
    {
        newEvent.AddListener(listener);
    }

}
