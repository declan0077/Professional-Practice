using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceScript : MonoBehaviour
{
    public AudioSource Bouncing;
    [SerializeField]
    float bounceForce = 500;
    private Rigidbody rb;
    Vector3 LastVelocity;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        LastVelocity = rb.velocity;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {


            Bouncing.Play();
            if (collision.gameObject.GetComponent<Rigidbody>())
            {
                collision.gameObject.GetComponent<Rigidbody>().AddForce(rb.velocity * 1000);
            }

        }
     
    }
}
