using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pinscript : MonoBehaviour
{
    public Bowlingtext text;
    public Vector3 startpos;
    public Transform rot;
    private void Start()
    {
        startpos = gameObject.transform.position;
        rot = gameObject.transform;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ground"))
        {
           
            text.score += 1;
            this.tag  = "dead";

        }
      
    }
    public void hit()
    {

    }

}
