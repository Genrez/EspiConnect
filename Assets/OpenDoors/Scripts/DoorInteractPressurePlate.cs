﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteractPressurePlate : MonoBehaviour {

    [SerializeField] private GameObject doorGameObject;
    private IDoor door;
    private float timer;

    private void Awake() {
        door = doorGameObject.GetComponent<IDoor>();
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Player")) {
            // Player entered collider!
            door.OpenDoor();
        }
    }

}