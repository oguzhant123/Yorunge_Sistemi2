//using SimpleKeplerOrbits;

//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class OrbitChanger : MonoBehaviour
//{
//    private KeplerOrbitMover keplerOrbitMover;
//    private KeplerOrbitLineDisplay lineDisplay;
//    public GameObject Mesaj;
//    // Start is called before the first frame update
//    void Start()
//    {
//        keplerOrbitMover = GetComponent<KeplerOrbitMover>();
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        AttractorSettings.AttractorMass = 12345f;
//        if (Input.GetKey(KeyCode.Alpha1))
//        {

//            keplerOrbitMover.VelocityHandleLenghtScale = 20f;

//        }
//        if (Input.GetKey(KeyCode.Alpha2))
//        {
//            keplerOrbitMover.VelocityHandleLenghtScale = 0f;
//        }
//        if (Input.GetKey(KeyCode.Alpha3))
//        {
//            keplerOrbitMover.TimeScale = 5f;
//        }
//        if (Input.GetKey(KeyCode.Alpha4))
//        {
//            keplerOrbitMover.TimeScale = 1f;
//        }
//        if (Input.GetKey(KeyCode.Alpha5))
//        {
//            keplerOrbitMover.AttractorSettings.AttractorMass = 12345f;
//        }
//        if (Input.GetKey(KeyCode.Alpha6))
//        {
//            keplerOrbitMover.AttractorSettings.AttractorMass = 1000f;
//        }
//        if (keplerOrbitMover.transform.position.x >= 3 && keplerOrbitMover.transform.position.y >= -1 && keplerOrbitMover.transform.position.z >= 2)
//        {
//            Mesaj.active = true;
//        }
//        if (keplerOrbitMover.transform.position.x >= 3 && keplerOrbitMover.transform.position.y >= -3 && keplerOrbitMover.transform.position.z <= -6)
//        {
//            Mesaj.active = false;
//        }
//    }
//}
