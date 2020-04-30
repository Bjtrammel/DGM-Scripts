using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVars : MonoBehaviour
{
    public bool haveAxe;
    public bool gateKeeper;
    public bool haveMirror;
    public IntData coinCount;

    private void Start()
    {
        coinCount.value = 0;
    }
}
