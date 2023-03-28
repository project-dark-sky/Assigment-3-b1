using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// camera traking script
public class MinimapScript : MonoBehaviour
{
    public Transform player;
    public float sensitivity = 1.0f;

    void LateUpdate()
    {
        Vector3 newPosition = player.position * sensitivity;
        newPosition.z = transform.position.z;
        transform.position = newPosition;
    }
}
