using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam4to5 : MonoBehaviour
{

    public Camera camera4;
    public Camera camera5;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("shift to cam 4");
        camera4.enabled = false;
        camera5.enabled = true;
    }
}
