using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

    public IntData currentHealth;
    public IntData takeDamage;
    public void Start()
    {
        currentHealth.value = 4;
    }

    public void ChangeHealth()
    {
        currentHealth.value -= takeDamage.value;
        Debug.Log("Player Health = " + currentHealth.value);
    }

    private void Update()
    {
        if (currentHealth.value <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(2);
        }
    }
}

 