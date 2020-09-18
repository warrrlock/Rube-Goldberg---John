using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam1to2 : MonoBehaviour
{

    public Camera camera1;
    public Camera camera2;
        
    private void OnTriggerEnter2D(Collider2D trigball1)
    {
        camera1.enabled = false;
        camera2.enabled = true;
    }
}
