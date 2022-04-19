using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingFloorFix : MonoBehaviour
{
    [SerializeField]
    bool isFalse;

    Rigidbody myRB;
    private bool checking = false;

    private Vector3 startLocation;

    private void Start()
    {
        myRB = GetComponent<Rigidbody>();
      startLocation = transform.position;
        StartCoroutine("DoCheck");
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            if (isFalse)
            {
                DropFloor();
                StartCoroutine("DoCheck");
            }
            else
            {
                StartCoroutine("DoCheck");
            }
        }
    }
    IEnumerator DoCheck()
    {
        checking = true;
        myRB.isKinematic = false;
        transform.position = startLocation;
        myRB.velocity = new Vector3(0, 0, 0);
        myRB.useGravity = false;
        myRB.mass = 50;
        yield return new WaitForSeconds(1f);
        checking = false;
  

    }

    private void DropFloor()
    {
        myRB.isKinematic = true;
        myRB.useGravity = true;
        StartCoroutine("DoCheck");
        myRB.mass = 1;
    }

    private void Restart()
    {
        myRB.isKinematic = false;
        this.transform.position = startLocation;
        StartCoroutine("DoCheck");

    }


}
