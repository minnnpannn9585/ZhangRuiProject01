using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PencilSceneOne : MonoBehaviour
{
    public GameObject dialoguebox;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //trigger dialogue
            dialoguebox.SetActive(true);
        }
    }
}
