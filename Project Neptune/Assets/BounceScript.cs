using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceScript : MonoBehaviour
{
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
        if (collision.gameObject.CompareTag("Object"))
        {

            var speed = LastVelocity.magnitude;
            var direction = Vector3.Reflect(LastVelocity.normalized, collision.contacts[0].normal);

            rb.velocity = direction * Mathf.Max(speed, 0f);

        }
     
    }
}
