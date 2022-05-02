using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingFloorFix : MonoBehaviour
{
    public AudioSource Floorcreak;
    public AudioSource FloorFall;

    [SerializeField]
    bool isFalse;

    Rigidbody myRB;

    private Vector3 startLocation;

    private void Start()
    {
        myRB = GetComponent<Rigidbody>();
        startLocation = transform.position;
        StartCoroutine("DoCheck");

        Floorcreak.Play();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            if (isFalse == false)
            {
                DropFloor();
            }
            else if (isFalse == true)
            {

            }
        }
    }
    IEnumerator DoCheck()
    {
        yield return new WaitForSeconds(5f);
        myRB.isKinematic = false;
        transform.position = startLocation;
        myRB.useGravity = false;




    }

    private void DropFloor()
    {
        Debug.Log("DA");
        myRB.isKinematic = true;
        myRB.useGravity = true;
        StartCoroutine("DoCheck");
        FloorFall.Play();
    }

    private void Restart()
    {
        myRB.isKinematic = false;
        this.transform.position = startLocation;
        StartCoroutine("DoCheck");

    }


}
