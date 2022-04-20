using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    private GameObject Player;
    public Vector3 Pos1;

    public Vector3 Pos2;
    private bool Point;

    private Rigidbody rb;
    private void Awake()
    {
        Pos1 =  this.transform.position + Pos1;
        Pos2 =  this.transform.position + Pos2;
        rb = GetComponent<Rigidbody>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Player = other.gameObject;
            Player.transform.parent = transform;
        }
      
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            Player.transform.parent = null;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawSphere(Pos1, 0.5f);
        Gizmos.DrawSphere(Pos2, 0.5f);
    }

    private void FixedUpdate()
    {
        if (Point = false)
        {
            rb.MovePosition(Pos2);
            if (rb.transform.position == Pos2)
            {
                Point = true;
                rb.MovePosition(Pos1);
            }
        }
        
    }
}
