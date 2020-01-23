using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


[CreateAssetMenu]
public class DebugObject : ScriptableObject
{
    public void OnDebug(string message)
    {
        Debug.Log(message);
    }
}

/*[CreateAssetMenu]
public class GameAction : ScriptableObject
{
    public UnityAction action;

    public void Raise()
    {
        action?.Invoke();
    }
}

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public float value = 1f;
}

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public int value = 1;
}*/ //Doesn't work, script has to have the same name as object