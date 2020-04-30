using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDialogue : MonoBehaviour
{
    public bool social;
    public GameObject coinDialogue;
    public GameObject giveDialogue;
    public GameObject player;
    public FloatData shootSpeed;
    private void OnTriggerEnter(Collider other)
    {
	if (other.gameObject.CompareTag("Player") == true)
        {
            social = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player") == true)
        {
            social = false;
            coinDialogue.SetActive(false);
        }

    }

    private void Update()
    {
        if (player.GetComponent<PlayerVars>().coinCount.value < 5 && Input.GetButtonDown("Interaction") && social == true)
        {
            coinDialogue.SetActive(true);
        }
        
        if (player.GetComponent<PlayerVars>().coinCount.value >= 5 && Input.GetButtonDown("Interaction") && social == true)
        {
            giveDialogue.SetActive(true);
            shootSpeed.value = 1.5f;
        }
    }
}
