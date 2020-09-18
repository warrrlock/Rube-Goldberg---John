using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam0to1 : MonoBehaviour
{

    public Camera camera0;
    public Camera camera1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        camera0.enabled = false;
        camera1.enabled = true;
    }
}
