using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;
using TMPro;
public class PlayerNameAboveHead : MonoBehaviour
{
 public TextMeshPro Name;
        private void Start()
    {
        Name.text = PhotonNetwork.NickName;
    }


}
