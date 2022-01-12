using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject carToFollow;
    void Update()
    {
        transform.position = carToFollow.transform.position + new Vector3(0, 0, -10);
    }
}
