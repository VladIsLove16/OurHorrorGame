using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ValueButton : MonoBehaviour
{
    public UnityEvent OnPress=new UnityEvent();
    private void OnTriggerEnter2D(Collider2D other)
    {
        OnPress.Invoke();
        Console.Write(" OnPress.Invoke();");
    }
}
