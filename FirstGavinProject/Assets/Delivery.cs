using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasTargetOnboard = false;
    [SerializeField] Color32 hasTargetColour = new Color32(20, 200, 40, 250);
    [SerializeField] Color32 noTargetColour = new Color32(200, 20, 140, 250);
    SpriteRenderer spriteRenderer;
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Object hit");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Target" && !hasTargetOnboard)
        {
            Debug.Log("Reached the target");
            hasTargetOnboard = true;
            Destroy(other.gameObject, 0.1f);
            spriteRenderer.color = hasTargetColour;
        }
        if (other.tag == "Checkpoint" && hasTargetOnboard)
        {
            Debug.Log("Reached the destination");
            hasTargetOnboard = false;
            spriteRenderer.color = noTargetColour;
        }
    }
}
