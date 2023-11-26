using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportPoint;
    private void OnTriggerEnter(Collider other)
    {
        Transform otherTransform = other.GetComponent<Transform>();
        if (otherTransform) 
         {
            otherTransform.position = teleportPoint.position;
         }
    }
}
