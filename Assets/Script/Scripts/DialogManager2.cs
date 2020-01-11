using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager2 : MonoBehaviour
{
    
    public Text GuneyYKText;

    public Queue<string> sentences2;
    // Start is called before the first frame update
    void Start()
    {
        sentences2 = new Queue<string>();
    }

    public void StartDialogue2(Dialogue dialogue)
    {
        Debug.Log("Starting conversation with" + dialogue.name);

        
        GuneyYKText.text = dialogue.name;

        sentences2.Clear();
        foreach (string sentence2 in dialogue.sentences)
        {
            sentences2.Enqueue(sentence2);
        }

        //DisplayNextSentence();
        DisplayNextSentence2();
    }

    //public void DisplayNextSentence()
    //{
    //    if (sentences2.Count == 0)
    //    {
    //        EndDialogue();
    //        return;
    //    }

    //    string sentence = sentences2.Dequeue();

    //}
    public void DisplayNextSentence2()
    {
        if (sentences2.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence2 = sentences2.Dequeue();
        GuneyYKText.text = sentence2;
    }
    void EndDialogue()
    {
        Debug.Log("End of conversation");
    }


}
