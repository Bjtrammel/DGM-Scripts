using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FarmerDialogue : MonoBehaviour
{
    public bool social;
    public GameObject canvasDialogue;
    public GameObject theEndDialogue;
    public GameObject theFinalCountdown;
    public GameObject player;

    public IntData mirrorQuestTimer;

    public Text label;
    //public IntData listNumber;
    //public StringListManager setListNum;

    private void Start()
    {
        mirrorQuestTimer.value = 90;
    }


    private void OnTriggerEnter(Collider other)
    {
        social = true;
    }

    private void OnTriggerExit(Collider other)
    {
        social = false;
        canvasDialogue.SetActive(false);
        StartCoroutine(MirrorQuestCountdown());
    }

    private void Update()
    {
        if (player.GetComponent<PlayerVars>().haveMirror == false && Input.GetButtonDown("Interaction") && social == true)
        {
            canvasDialogue.SetActive(true);
            theFinalCountdown.SetActive(true);
        }
        
        if (player.GetComponent<PlayerVars>().haveMirror == true && Input.GetButtonDown("Interaction") && social == true)
        {
            StopCoroutine(MirrorQuestCountdown());
            mirrorQuestTimer.value = 90;
            theEndDialogue.SetActive(true);
            theFinalCountdown.SetActive(false);
        }

        if (mirrorQuestTimer.value <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(2);
        }
    }

    public IEnumerator MirrorQuestCountdown()
    {
        while (mirrorQuestTimer.value > 0)
        {
            yield return new WaitForSeconds(1);
            label.text = mirrorQuestTimer.value.ToString();
            mirrorQuestTimer.value --;
        }

    }
}
