using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam3to4 : MonoBehaviour
{

    public Camera camera3;
    public Camera camera4;

    private void OnTriggerEnter2D(Collider2D trigball3)
    {
        Debug.Log("shift to cam 4");
        camera3.enabled = false;
        camera4.enabled = true;
    }
}
