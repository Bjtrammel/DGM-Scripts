using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    
    public void AddCoin()
         {
             player.GetComponent<PlayerVars>().coinCount.value ++;
         }

    public void PickUpCoin()
    {
        Destroy(gameObject);
    }
}
