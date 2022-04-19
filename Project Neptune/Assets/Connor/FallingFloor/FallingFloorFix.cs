using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingFloorFix : MonoBehaviour
{
    [SerializeField]
    bool isFalse;

    Rigidbody myRB;
    private bool checking = false;

    private Transform startLocation;

    private void Start()
    {
        myRB = GetComponent<Rigidbody>();
      startLocation = this.transform;
        StartCoroutine("DoCheck");
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
                Invoke("Restart", 3);
            }
        }
    }
    IEnumerator DoCheck()
    {
        checking = true;
        myRB.isKinematic = false;
        this.transform.position = startLocation.position;
        myRB.velocity = new Vector3(0, 0, 0);
        yield return new WaitForSeconds(1f);
        StartCoroutine("DoCheck");
        checking = false;
  

    }

    private void DropFloor()
    {
        myRB.isKinematic = true;
    }

    private void Restart()
    {
        myRB.isKinematic = false;
        myRB.velocity = new Vector3(0, 0, 0);
        this.transform.position = startLocation.position;
        this.transform.rotation = startLocation.rotation;

    }


}
