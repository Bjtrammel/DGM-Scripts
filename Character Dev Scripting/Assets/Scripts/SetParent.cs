
using UnityEditor;
using UnityEngine;

public class SetParent : MonoBehaviour
{

    public GameObject parentObj;
    
    private void AssignParent(Collider other)
    {
        transform.parent = other.transform;
    }

}
