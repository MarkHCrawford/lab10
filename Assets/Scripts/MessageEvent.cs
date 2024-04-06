using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MessageEvent : UnityEvent
{
    public void AddNoArgumentsListener(UnityAction listener)
    {
        AddListener(listener);
    }
}

