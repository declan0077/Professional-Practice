using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceScriptObject : MonoBehaviour
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

            var speed = LastVelocity.magnitude;
            var direction = Vector3.Reflect(LastVelocity.normalized, collision.contacts[0].normal);
           
            collision.rigidbody.velocity = direction * Mathf.Max(speed, 0f);
            Bouncing.Play();
        }
     
    }
}
