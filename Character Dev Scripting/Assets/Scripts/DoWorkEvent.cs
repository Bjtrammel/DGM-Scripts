﻿using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Events;

public class DoWorkEvent : MonoBehaviour
{

    public UnityEvent Event;

    public void WorkTest(Collider other)
    {
        Event.Invoke();
    }
}