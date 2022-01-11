using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintToConsole : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Object hit");
    }
}
