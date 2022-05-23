using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldEndColliderScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            other.GetComponent<FirstPersonController>().restart();
            other.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }
    }
}
