using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pickup : MonoBehaviour
{
 


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
          other.GetComponent<FirstPersonController>().mousemovement = 500;
        Destroy(gameObject);  
        }
        
    }
}
 