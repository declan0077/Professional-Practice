using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class CheckgroundScript : MonoBehaviour
{
    private AudioSource AS;
    private PhotonTransformView PTV;
    private void Start()
    {
        PhotonNetwork.AutomaticallySyncScene = true;
        AS = GetComponent<AudioSource>();
        PTV = GetComponent<PhotonTransformView>();
    }
    private void Update()
    {
       
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Ground"))
        {
            AS.Play();
        }
    }

}
