using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingBall : MonoBehaviour
{
    public float speed = 0.05f;
    public float rightExtent = 8.5f;
    public float leftExtent = -8.5f;
    public int min_click_speed = 100;

    public GameObject fallingBall;

    private Vector3 direction = Vector3.right;
    private System.DateTime lastClicked = System.DateTime.UtcNow;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move right and left
        transform.Translate(direction * speed);
        
        if (transform.position.x > rightExtent)
        {
            direction = Vector3.left;
        }
        else if (transform.position.x < leftExtent)
            { direction = Vector3.right; 
        }

        //Register click to generate the falling ball
        System.TimeSpan time_diff = (System.DateTime.UtcNow - lastClicked);
        if (time_diff.TotalMilliseconds > min_click_speed && Input.GetKey("mouse 0"))
        {
            
            lastClicked = System.DateTime.UtcNow;
            Instantiate(fallingBall, transform.position, Quaternion.identity);
        }
    }

}
