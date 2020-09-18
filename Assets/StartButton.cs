using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("space function started");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
           // gameObject.GetComponent<Rigidbody2D>().gravityScale = 1.4f;
            Debug.Log("space");
        }
    }
}
