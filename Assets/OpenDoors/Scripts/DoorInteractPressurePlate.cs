using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteractPressurePlate : MonoBehaviour
{

    [SerializeField] private GameObject[] doorGameObjects;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        AudioSource button = GameObject.FindGameObjectWithTag("Button").GetComponent<AudioSource>();
        if (collision.CompareTag("Player"))
        {
            for (int i = 0; i < doorGameObjects.Length; ++i)
            {
                doorGameObjects[i].GetComponent<IDoor>().OpenDoor();
                button.enabled = true; 
            }
        }
    }

}
