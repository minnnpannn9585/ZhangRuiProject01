using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BtnCalm : MonoBehaviour
{
    public GameObject peopleCalm;
    public GameObject peopleHappy;
    public GameObject peopleAngry;

    public GameObject line1;
    public GameObject line2;
    public GameObject line3;
    public GameObject nextBtn;

    public TMP_Text text;
    public SelectOptionBtn selectOptionBtn;
    public GameObject option1;
    public GameObject option2;

    public string[] dialogues;

    public void ClickCalm()
    {
        DialogueManagerNew.instance.dialogues = dialogues;
        DialogueManagerNew.instance.StartDialogue();

        peopleCalm.SetActive(true);
        peopleHappy.SetActive(false);
        peopleAngry.SetActive(false);
        text.text = "calm";
        line1.SetActive(true);
        line2.SetActive(true);
        line3.SetActive(true);
        nextBtn.SetActive(true);
        selectOptionBtn.enabled = false;
        option1.SetActive(false);
        option2.SetActive(false);
    }
}
