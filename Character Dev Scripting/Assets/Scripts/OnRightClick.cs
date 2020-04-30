
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnRightClick : MonoBehaviour
{
    public UnityEvent OnRight;
    public OnRightClick()
    {
        OnRight.Invoke();
    }
}

