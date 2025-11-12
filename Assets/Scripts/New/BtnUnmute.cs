using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BtnUnmute : MonoBehaviour
{
    public GameObject bgm;
    public GameObject people;
    public GameObject line1;
    public GameObject line2;
    public GameObject nextBtn;
    
    public TMP_Text text;
    public SelectOptionBtn selectOptionBtn;
    public GameObject option;

    public string[] dialogues;

    public void ClickUnmute()
    {
        DialogueManagerNew.instance.dialogues = dialogues;
        DialogueManagerNew.instance.StartDialogue();
        nextBtn.SetActive(true);
        transform.parent.parent.GetChild(1).gameObject.SetActive(false);
        transform.parent.parent.GetChild(2).gameObject.SetActive(false);
        people.SetActive(true);
        line1.SetActive(true);
        line2.SetActive(true);
        bgm.SetActive(true);
        text.text = "unmute";
        selectOptionBtn.enabled = false;
        option.SetActive(false);
    }
}
