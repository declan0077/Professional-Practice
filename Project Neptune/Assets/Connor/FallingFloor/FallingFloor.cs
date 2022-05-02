using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingFloor : MonoBehaviour
{
    public AudioSource Floorcreak;
   

    bool isFalse;
    Renderer myRend;

    [SerializeField] FallingFloor[] group;
    Rigidbody myRB;

    [SerializeField] bool UnvealPath;

    private void OnEnable()
    {
        myRend = GetComponent<Renderer>();
        myRB = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        Floorcreak.Play();
        
        if (group.Length == 0)
            return;

        int pathIndex = Random.Range(0, group.Length);
        for (int i = 0; i < group.Length; i++)
        {
            if (pathIndex == i)
            {
                group[i].SetPath();
            }
            else
            {
                group[i].SetFalsePath();
            }

        }

    }
    public void SetPath()
    {
        isFalse = false;
        myRB.isKinematic = true;
        if (UnvealPath)
        {

        }
    }
    public void SetFalsePath()
    {
        isFalse = true;
        myRB.isKinematic = false;
        if (UnvealPath)
        {

        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "player")
        {
            if (isFalse)
            {

            }
            else
            {

            }
        }
    }
}
