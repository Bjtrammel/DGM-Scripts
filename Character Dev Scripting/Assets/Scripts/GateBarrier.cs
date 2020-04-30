using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GateBarrier : MonoBehaviour
{
    public GameObject toDisable;
    public GameObject canvasDialogue;
    public GameObject player;
    
    
    public void BarrierClear()
    {
        if (player.GetComponent<PlayerVars>().gateKeeper == true)
        {
            Debug.Log("This Actually Worked");
            toDisable.SetActive(false);
           // canvasDialogue.SetActive(true);
            //Instantiate(canvasDialogue);
        }
    }
}

