using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OynatBtn : MonoBehaviour
{
    public GameObject Sun, Sun1;
    public GameObject Earth, Earth1, Earth2;
    public GameObject Moon;
    public Transform canvas;
    public GameObject gameObject;
    public Camera MainCamera, camera, camera2;
    

    public void Oynat()
    {
        Sun.active = true;
        Sun1.active = false;
        Earth.active = true;
        Earth1.active = false;
        Earth2.active = false;
        Moon.active = true;
        canvas.GetComponent<Canvas>().enabled = false;
        gameObject.active = false;
        MainCamera.GetComponent<Camera>().enabled = true;
        camera.GetComponent<Camera>().enabled = false;
        
    }
    //void Update()
    //{
    //    if (Input.GetKey(KeyCode.Alpha1))
    //    {
    //        Debug.Log("Girildi.");
    //        camera2.enabled = true;
    //        MainCamera.enabled = false;
    //        camera.enabled = false;
    //    }
    //}
}
