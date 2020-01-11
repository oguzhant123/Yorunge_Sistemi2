using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public float counter;
    public float dist;

    public Transform sun;
    public Transform earth;

    public float lineDrawSpeed = 6f;
    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.SetPosition(0, sun.position);
        lineRenderer.SetWidth(.05f, .05f);

        dist = Vector3.Distance(sun.position, earth.position);
    }

    // Update is called once per frame
    void Update()
    {
       
        if (counter < dist)
        {
            counter += .1f / lineDrawSpeed;
            float x = Mathf.Lerp(0, dist, counter);

            Vector3 pointA = sun.position;
            Vector3 pointB = earth.position;

            Vector3 pointLongLine = x * Vector3.Normalize(pointB - pointA) + pointA;

            lineRenderer.SetPosition(1, pointLongLine);
        }      
    }
}
