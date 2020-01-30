using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public float value; //field visible in unity
	
    public virtual float Value //property can modify itself when called //virtual means it can be overriden by something that calls it. //paramater
    {
        get { return value;} //get-method gets data returns value which can change. 
    }
}
