using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : PlayerHealth
{
    // Start is called before the first frame update

        public void Death()
        {
            if (currentHealth.value <= 0)
            {
                Destroy(gameObject);
                SceneManager.LoadScene(2);
            }
        }
 }