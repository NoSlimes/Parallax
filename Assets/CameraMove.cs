using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    GameObject cam;
    [SerializeField]float ScrollSpeed;
    void Start()
    {
        cam = this.gameObject;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        Vector3 camPos = cam.transform.position;
        cam.transform.position = new Vector3(camPos.x + ScrollSpeed, camPos.y, camPos.z);
    }
}
