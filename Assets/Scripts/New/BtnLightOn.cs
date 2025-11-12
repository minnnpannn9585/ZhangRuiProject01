using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BtnLightOn : MonoBehaviour
{

    public Sprite lightOn;
    public GameObject flower;

    public Image env;
    
    public TMP_Text text;
    public SelectOptionBtn selectOptionBtn;
    public GameObject option;

    public void ClickLightOn()
    {
        transform.parent.parent.GetChild(1).gameObject.SetActive(false);
        transform.parent.parent.GetChild(2).gameObject.SetActive(false);
        flower.SetActive(true);
        env.sprite = lightOn;
        text.text = "on";
        selectOptionBtn.enabled = false;
        option.SetActive(false);
    }
}
