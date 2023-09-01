using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class FinishLine : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition;
        GameObject message = GameObject.Find("Messages");
        Vector3 message_pos = message.transform.position;
        message.transform.position = new Vector3(message_pos.x, message_pos.y, 0);
    }
}
