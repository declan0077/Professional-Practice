using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateTriggerHold : MonoBehaviour
{
    public GameObject FloorMoving;
    public Material On;
    public Material Off;
    private bool OnOrOff = false;
    private void OnTriggerEnter(Collider other)
    {
        if(OnOrOff == false && other.tag == "Object")
        {
            this.GetComponent<MeshRenderer>().material = On;
            Debug.Log("on");
            OnOrOff = true;
            FloorMoving.GetComponent<Animator>().enabled = true;
            FloorMoving.GetComponent<Animator>().Play("platform");
          
        }

       
    }
    private void OnTriggerExit(Collider other)
    {
        if (OnOrOff == true && other.tag == "Object")
        {
            this.GetComponent<MeshRenderer>().material = Off;
            Debug.Log("off");
            OnOrOff = false;
           
        }
    }
}
