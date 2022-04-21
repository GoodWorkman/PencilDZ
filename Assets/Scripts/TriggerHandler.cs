using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerHandler : MonoBehaviour
{
    public UnityEvent onTriggerEnter2D;
    public UnityEvent onTriggerExit2D;
    
    public void OnTriggerEnter2D(Collider2D col)
    {
        onTriggerEnter2D.Invoke();
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        onTriggerExit2D.Invoke();
    }
}
