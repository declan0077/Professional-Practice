using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;
using TMPro;

public class PlayerNameAboveHead : MonoBehaviour
{

 public TextMeshPro Name;
    public string Playername;
    public int PlayerNumber;
    public void NameSelf()
    {

        Name.text = Playername + PlayerNumber ; 
    }


}
