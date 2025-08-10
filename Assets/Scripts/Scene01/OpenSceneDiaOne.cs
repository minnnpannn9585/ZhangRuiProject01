using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSceneDiaOne : MonoBehaviour
{
    public DialogueManager dialogueManager;
    public string[] dialogues;
    public string[] names;

    public void Start()
    {
        dialogueManager.dialogues = dialogues;
        dialogueManager.names = names;
        dialogueManager.StartDialogue();
    }
}
