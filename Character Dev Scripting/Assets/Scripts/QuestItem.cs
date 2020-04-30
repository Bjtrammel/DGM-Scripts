using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class QuestItem : MonoBehaviour
{
    public bool questItemPickUp;

    public void QuestItemIsPickedUp()
    {
        questItemPickUp = true;
    }
}
