using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scriptplayername : MonoBehaviour
{
    private int PlayerNumber;
    
    private void OnTriggerEnter(Collider other)
    {
   
        if (other.CompareTag("Player"))
        {
            PlayerNumber += 1;
           other.GetComponentInChildren<PlayerNameAboveHead>().Playername = "Player";
           other.GetComponentInChildren<PlayerNameAboveHead>().PlayerNumber = PlayerNumber;
           other.GetComponentInChildren<PlayerNameAboveHead>().NameSelf();
        }

    }
}
