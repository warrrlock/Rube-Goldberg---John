using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eating_anim : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite[] eatAnim = new Sprite[2];
    private int currentFrame;
    public float animFPS = 10;
    private float previousFrameTime;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = eatAnim[currentFrame];

        if (Time.time - previousFrameTime > 1 / animFPS)
        {
            previousFrameTime = Time.time;
            currentFrame++;
            if (currentFrame > eatAnim.Length - 1) currentFrame = 0;
        }
    }
}