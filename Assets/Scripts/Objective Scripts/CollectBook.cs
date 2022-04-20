using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectBook : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Works");
        Destroy(gameObject);
    }
}
