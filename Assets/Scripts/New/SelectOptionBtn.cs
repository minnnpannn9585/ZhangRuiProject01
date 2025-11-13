using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectOptionBtn : MonoBehaviour
{
    private GameObject option;
    private GameObject option2;
    private GameObject option3;
    Button button;
    private bool isOn = false;
    
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        option = transform.GetChild(3).gameObject;
        if (transform.childCount == 5)
        {
            option2 = transform.GetChild(4).gameObject;
        }

        if (transform.childCount == 6)
        {
            option2 = transform.GetChild(4).gameObject;
            option3 = transform.GetChild(5).gameObject;
        }
        
        button.onClick.AddListener(TurnOnOffOption);
    }

    public void TurnOnOffOption()
    {
        isOn = !isOn;
        option.SetActive(isOn);
        if (option2 != null)
        {
            option2.SetActive(isOn);
        }

        if (option3 != null)
        {
            option3.SetActive(isOn);
        }
    }

    private void OnDisable()
    {
        transform.SetSiblingIndex(0);
        button.onClick.RemoveAllListeners();
    }
}
