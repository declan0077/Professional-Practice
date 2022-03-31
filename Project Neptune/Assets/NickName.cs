using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
public class NickName : MonoBehaviour
{
    public InputField nameseflfInput;
    public void nickname()
    {
        PhotonNetwork.NickName = nameseflfInput.text.ToString();
    }

}
