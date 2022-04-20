using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateTrigger : MonoBehaviour
{
    public GameObject plate;
    public Material On;
    public Material Off;
    private bool OnOrOff = false;
    private void OnTriggerEnter(Collider other)
    {
        if(OnOrOff == false)
        {
            plate.GetComponent<MeshRenderer>().material = On;
            Debug.Log("on");
            OnOrOff = true;
        }
        else
        {
            plate.GetComponent<MeshRenderer>().material = Off;
            Debug.Log("off");
            OnOrOff = false;
        }
       
    }
}
