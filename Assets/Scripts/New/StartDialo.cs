using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDialo : MonoBehaviour
{
    public string[] dialogues;
    void Start()
    {
        DialogueManagerNew.instance.dialogues = dialogues;
        DialogueManagerNew.instance.StartDialogue();
    }
}
