using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeDialogue : MonoBehaviour
{

    public GameObject canvasDialogue;
    private void OnTriggerEnter(Collider other)
    {
        canvasDialogue.SetActive(false);
    }
}
