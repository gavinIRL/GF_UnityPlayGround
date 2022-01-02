using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // var declaration
    [SerializeField] float moveSpeed = 0.005f;
    [SerializeField] float turnSpeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(0, 0, -90);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, turnSpeed);
        transform.Translate(0, moveSpeed, 0);
    }
}
