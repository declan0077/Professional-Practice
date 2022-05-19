using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwiningballScript : MonoBehaviour
{
    Rigidbody rb;
    private void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Rigidbody>())
        {
            other.GetComponent<Rigidbody>().AddForce(rb.velocity * 1000);
        }
       
    }
}
