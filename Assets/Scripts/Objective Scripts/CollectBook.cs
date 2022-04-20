using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectBook : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Works");
        Destroy(gameObject);
        SceneManager.LoadScene("VictoryScreen");
    }
}
