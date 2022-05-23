using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bowlingball : MonoBehaviour
{
    public Vector3 startpos;
    public Bowlingtext text;
    private Rigidbody rb;
    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        startpos = this.transform.position;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pin"))
        {
            other.gameObject.GetComponent<pinscript>().hit();
            text.score += 1;
            other.gameObject.tag = "dead";
        }
        if (other.CompareTag("Goal"))
        {
            gameObject.transform.position = startpos;
            rb.velocity = new Vector3();

        }
    }
}
