using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager3 : MonoBehaviour
{
    
    public Text info;

    public Queue<string> sentences3;
    // Start is called before the first frame update
    void Start()
    {
        sentences3 = new Queue<string>();
    }

    public void StartDialogue3(Dialogue dialogue)
    {
        Debug.Log("Starting conversation with" + dialogue.name);

        
        info.text = dialogue.name;

        sentences3.Clear();
        foreach (string sentence3 in dialogue.sentences)
        {
            sentences3.Enqueue(sentence3);
        }

        //DisplayNextSentence();
        DisplayNextSentence3();
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
    public void DisplayNextSentence3()
    {
        if (sentences3.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence3 = sentences3.Dequeue();
        info.text = sentence3;
    }
    void EndDialogue()
    {
        Debug.Log("End of conversation");
    }


}
