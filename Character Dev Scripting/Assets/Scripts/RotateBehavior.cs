/*

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBehavior : MonoBehaviour
{
    public int Right = 90;
    public int Left = -90;
    public int Hold = 3;

    private Vector3 rotDirection;
    
    void Start()
    {
        StartCoroutine(RotateAround());
    }

    public IEnumerator RotateAround()
    {
        yield return new WaitForSeconds(Hold);
        //rotDirection.Set(0, Right, 0);
        gameObject(transform.rotation, 0, Right, 0);
        gameObject(transform.rotation, 0, Right, 0);
        gameObject(transform.rotation, 0, Left, 0);

    }
}

*/
