using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextSentenceBtnNew : MonoBehaviour
{

    public void NextSen()
    {
        DialogueManagerNew.instance.DisplayNextSentence();
    }
}
