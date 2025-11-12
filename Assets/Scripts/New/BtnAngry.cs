using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BtnAngry : MonoBehaviour
{
    public Image people;
    public Sprite angry;
    public GameObject line1;
    public GameObject line2;
    public GameObject nextBtn;
    
    public TMP_Text text;
    public SelectOptionBtn selectOptionBtn;
    public GameObject option1;
    public GameObject option2;

    public void ClickAngry()
    {
        people.sprite = angry;
        text.text = "angry";
        line1.SetActive(true);
        line2.SetActive(true);
        nextBtn.SetActive(true);
        selectOptionBtn.enabled = false;
        option1.SetActive(false);
        option2.SetActive(false);
    }
}
