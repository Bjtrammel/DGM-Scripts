using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinDisplay : MonoBehaviour
{
    public Text label;
    private PlayerVars _vars;
    public IntData coinCounter;

    // Update is called once per frame
    void Update()
    {
        label.text = coinCounter.value.ToString();
    }
}
