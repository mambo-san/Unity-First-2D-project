using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Galaxy : MonoBehaviour
{

    public float speed = 0.001f;
    public Vector3 direction = Vector3.right;
    public float starting_pos = -9;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed);
        
    }

    private void OnBecameInvisible()
    {
        Vector3 current_pos = transform.position;
        transform.position = new Vector3(starting_pos, current_pos.y, current_pos.z);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }

}
