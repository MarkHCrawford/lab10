using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoker : MonoBehaviour
{
    [SerializeField]
    private TimerScript timer;


    private Event newEvent;

    private void Awake()
    {
        if (newEvent == null)
        {
            newEvent = new Event();
        }

    }

    private void Start()
    {
        newEvent.AddListener();
    }
}
