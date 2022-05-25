using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckgroundScript : MonoBehaviour
{
    private AudioSource AS;
    private void Start()
    {
        AS = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Ground"))
        {
            AS.Play();
        }
    }

}
