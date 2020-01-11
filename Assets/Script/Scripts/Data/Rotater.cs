using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Rotater : MonoBehaviour
{
    public float RotateSpeed = 5.0f;
    

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Vector3.up, RotateSpeed * Time.deltaTime);
    }
}
