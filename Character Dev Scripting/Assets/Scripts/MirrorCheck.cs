using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorCheck : MonoBehaviour
{

    public GameObject player;
    public void CheckMirror()
    {
        player.GetComponent<PlayerVars>().haveMirror = true;
    }

    public void PickUpMirror()
    {
        Destroy(gameObject);
    }
}
