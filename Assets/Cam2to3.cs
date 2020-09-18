using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam2to3 : MonoBehaviour
{

    public Camera camera2;
    public Camera camera3;

    private void OnTriggerEnter2D(Collider2D trigball2)
    {
        Debug.Log("shift to cam 3");
        camera2.enabled = false;
        camera3.enabled = true;
    }
}
