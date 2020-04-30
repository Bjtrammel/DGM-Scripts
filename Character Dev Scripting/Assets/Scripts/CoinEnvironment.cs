using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinEnvironment : MonoBehaviour
{
    public bool inspect;
    public bool coinPickedUp;
    public GameObject player;
    
    
    private void OnTriggerEnter(Collider other)
    {
        inspect = true;
        print("Hello");
    }

    private void OnTriggerExit(Collider other)
    {
        inspect = false;
    }

    void Update()
    {
        if (Input.GetButtonDown("Interaction") && inspect == true && coinPickedUp == false)
        {
            player.GetComponent<PlayerVars>().coinCount.value ++;
            coinPickedUp = true;
        }
    }
}
