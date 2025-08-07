using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialBoxSceneOne : MonoBehaviour
{
    public GameObject uiPanel;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            uiPanel.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
