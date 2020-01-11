using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger3 : MonoBehaviour
{
    public Dialogue dialogue;

    public void TriggerDialogue3()
    {
        FindObjectOfType<DialogManager3>().StartDialogue3(dialogue);
    }
}
