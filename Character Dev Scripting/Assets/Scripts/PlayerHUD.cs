using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHUD : MonoBehaviour
{
    // Start is called before the first frame update
    public Text label;
    public IntData currentHealth;

    // Update is called once per frame
    void Update()
    {
        label.text = currentHealth.value.ToString();
    }
}
