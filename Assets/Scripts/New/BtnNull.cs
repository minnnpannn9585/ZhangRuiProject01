using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BtnNull : MonoBehaviour
{
    public GameObject peopleCalm;
    public GameObject peopleFree;

    
    public GameObject line1;
    
    public TMP_Text text;
    public SelectOptionBtn selectOptionBtn;
    public GameObject option1;
    public GameObject option2;
    public GameObject option3;
    
    public string[] dialogues;

    public GameObject whiteImageAnim;

    public void ClickNull()
    {
        DialogueManagerNew.instance.dialogues = dialogues;
        DialogueManagerNew.instance.StartDialogue();
        
        peopleCalm.SetActive(false);
        peopleFree.SetActive(false);

        text.text = "null";
        
        line1.SetActive(true);
        selectOptionBtn.enabled = false;
        option1.SetActive(false);
        option2.SetActive(false);
        option3.SetActive(false);
        
        whiteImageAnim.SetActive(true);
    }
}
