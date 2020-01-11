using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    public Text KuzeyYKText;
    

    public Queue<string> sentences;
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        Debug.Log("Starting conversation with" + dialogue.name);

        KuzeyYKText.text = dialogue.name;
       

        sentences.Clear();
        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
        //DisplayNextSentence2();
    }
    
    public void DisplayNextSentence()
    {
        if (sentences.Count==0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        KuzeyYKText.text = sentence;
    }
    //public void displaynextsentence2()
    //{
    //    if (sentences.count == 0)
    //    {
    //        enddialogue();
    //        return;
    //    }

    //    string sentence = sentences.dequeue();
        
    //}
    void EndDialogue()
    {
        Debug.Log("End of conversation");
    }

    
}
