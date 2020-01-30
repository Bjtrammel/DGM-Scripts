using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    //public FloatData moveSpeed;
    public Transform target;

    //public NameID;

    public void Follow()
    {
    transform.LookAt(target);
    }
}
/*
using UnityEngine;
using System.Collections;

public class EnemyFollow : MonoBehaviour
{

    public float moveSpeed;
    public Transform target;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            transform.LookAt(target);
            //	transform.Translate(GetPosition);
        }
    }

} */