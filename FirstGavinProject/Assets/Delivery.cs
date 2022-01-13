using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Object hit");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Target")
        {
            Debug.Log("Reached the target");
        }
        if (other.tag == "Checkpoint")
        {
            Debug.Log("Reached the destination");
        }
    }
}
