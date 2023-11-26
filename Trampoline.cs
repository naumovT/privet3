using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
        public float jump = 5;
    private void OnTriggerEnter(Collider other) 
    {
         Jump player = other.GetComponent<Jump>();
         if (player) 
         {
            player.jumpStrength *= jump;
         }
    }
    
    private void OnTriggerExit(Collider other) 
    {
        Jump player = other.GetComponent<Jump>();
         if (player) 
         {
            player.jumpStrength /= jump;
         }
    }
}
