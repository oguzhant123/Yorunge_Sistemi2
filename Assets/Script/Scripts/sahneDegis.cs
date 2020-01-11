using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sahneDegis : MonoBehaviour
{
    public void GecisYap(int SahneNo)
    {
        SceneManager.LoadScene(SahneNo);
    }
}
