using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateKeeperDialogue : MonoBehaviour
{
    public bool social;
    public GameObject canvasDialogue;

    public GameObject player;
    //public IntData listNumber;
    //public StringListManager setListNum;
    
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
            player.GetComponent<PlayerVars>().gateKeeper = true;
            //setListNum.currentListNum = listNumber.value;
        }
    }
}
