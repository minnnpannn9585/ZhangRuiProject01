using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextSentenceBtn : MonoBehaviour
{
    public DialogueManager dialogueManager;

    public void NextSen()
    {
        dialogueManager.DisplayNextSentence();
    }
}
