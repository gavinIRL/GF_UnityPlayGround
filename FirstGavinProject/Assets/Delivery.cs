using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasTargetOnboard = false;
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Object hit");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Target")
        {
            Debug.Log("Reached the target");
            hasTargetOnboard = true;
            Destroy(other, 0.1f);
        }
        if (other.tag == "Checkpoint" && hasTargetOnboard)
        {
            Debug.Log("Reached the destination");
            hasTargetOnboard = false;
        }
    }
}
