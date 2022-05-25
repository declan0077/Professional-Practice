using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class Islocal : MonoBehaviour
{
    public GameObject lefteye, Righteye, tophat, tux;
    PhotonView view;
    // Start is called before the first frame update
    void Start()
    {
        view = GetComponent<PhotonView>();
        if (view.IsMine == true)
        {
            lefteye.SetActive(false);
            Righteye.SetActive(false);
            tophat.SetActive(false);
            tux.SetActive(false);
        }
    }

 
}
