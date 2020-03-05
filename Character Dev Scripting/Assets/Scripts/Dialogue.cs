using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public bool social;
    //public GameObject Douglas;
    
    private void OnTriggerEnter(Collider other)
    {
       // bool social = true;
       social.Equals(true);
        print("Hello");
    }

    private void OnTriggerExit(Collider other)
    {
        //bool social = false;
        social.Equals(false);
        print("Goodbye");
    }

    private void Update()
    {
        if (Input.GetButtonDown("Submit") && social.Equals(true))
        {
            print("I am NPC");
        }
    }
}
