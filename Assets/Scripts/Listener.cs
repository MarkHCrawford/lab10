using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


/***************************/
/* Mark Crawford           */
/* CSC 350H                */
/* Professor Tang          */
/* Lab 10, Listener Script */
/* 04/05/2024              */
/***************************/


public class NewBehaviourScript : MonoBehaviour
{
    // Get invoker
    private Invoker invoker;

    // Connect invoker
    private void Start()
    {
        invoker = gameObject.AddComponent<Invoker>();
        invoker.AddNoArgumentListener(PrintMessage);
    }

    public void PrintMessage()
    {
          Debug.Log("Check, check, checkity check.");
    }  

}
