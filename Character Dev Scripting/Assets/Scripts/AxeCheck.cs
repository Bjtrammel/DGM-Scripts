using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeCheck : MonoBehaviour
{

    public GameObject player;
    public void CheckAxe()
    {
        player.GetComponent<PlayerVars>().haveAxe = true;
    }
}
