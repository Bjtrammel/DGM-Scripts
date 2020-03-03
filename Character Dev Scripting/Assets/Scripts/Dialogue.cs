using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialouge : MonoBehaviour
{
    public bool social;

    private void OnTriggerEnter(Collider other)
    {
        bool social = true;
        print("Hello");
    }

    private void OnTriggerExit(Collider other)
    {
        bool social = false;
        print("Goodbye");
    }

    private void Update()
    {
        if (Input.GetButtonDown("Submit") && social(true))
        {
            print("I am NPC");
        }

        else
        {
            print("I don't know you");
        }
    }
}
