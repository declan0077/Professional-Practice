using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;
public class PlayerNameAboveHead : MonoBehaviour
{
 public TextMesh Name;
        private void Start()
    {
        Name.text = PhotonNetwork.NickName;
    }


}
