using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTransform : MonoBehaviour
{
    private GameObject objectToTransform;
    private SpriteRenderer playerSpriteRenderer;

    private void Start()
    {
        playerSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void Transform(string objectToTransform)
    {
        this.objectToTransform = GameObject.Find(objectToTransform);
        GetComponent<Animator>().enabled = false;
        playerSpriteRenderer.sprite = this.objectToTransform.GetComponent<SpriteRenderer>().sprite;
    }

    public void RevertTransform()
    {
        GetComponent<Animator>().enabled = true;
    }
}
