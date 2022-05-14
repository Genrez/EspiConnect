using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectBook : MonoBehaviour
{
    public GameObject victoryScreen;
    void OnTriggerEnter2D(Collider2D col)
    {
        victoryScreen.SetActive(true);
        AudioSource camera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<AudioSource>();
        camera.enabled = false;
        AudioSource player = GameObject.FindGameObjectWithTag("Player").GetComponent<AudioSource>();
        player.enabled = false;
    }
}
