using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefillHealth : MonoBehaviour
{
    public IntData currentHealth;
    
    public void Refill()
    {
        currentHealth.value = 4;
    }
}
