using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingFloorFix : MonoBehaviour
{
    [SerializeField]
    bool isFalse;

    Rigidbody myRB;


    private void Start()
    {
        myRB = GetComponent<Rigidbody>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            if (isFalse)
            {
                DropFloor();
                Destroy(this, 2);
            }
            else
            {

            }
        }
    }


    private void DropFloor()
    {
        myRB.isKinematic = true;
    }

}
