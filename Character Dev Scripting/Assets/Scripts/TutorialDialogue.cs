using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialDialogue : MonoBehaviour
{
    public bool social;
    public GameObject canvasDialogue; 
    private void OnTriggerEnter(Collider other)
    {
       social = true;
    }

    private void OnTriggerExit(Collider other)
    {
        social = false;
        canvasDialogue.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetButtonDown("Interaction") && social == true)
        {
            canvasDialogue.SetActive(true);
        }
    }
}
