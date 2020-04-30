using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public GameObject thePickUp;
    public IntData currentHealth;
    public Shoot shootData;
    public IntData enemyStartHealth;
    public GameObject parent;

    public void Start()
    {
        currentHealth.value = enemyStartHealth.value;
    }

    public void ChangeHealth()
    {
        currentHealth.value -= shootData.arrowDamage.value;
        Debug.Log("Enemy Health = " + currentHealth.value);
        DropPickUp();
    }


    private void DropPickUp()
    {
        if (currentHealth.value <= 0)
        {
            Instantiate(thePickUp, transform.position, transform.rotation);
            Destroy(parent);
        }
    }
}

 