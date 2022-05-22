using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;
public class PortalScript : MonoBehaviour
{
    public int Level = 0;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            switch (Level)
            {
                case 5:
                    PhotonNetwork.LoadLevel("Maze");
                    break;
                case 4:
                    PhotonNetwork.LoadLevel("Bowling");
                    break;
                case 3:
                    PhotonNetwork.LoadLevel("ConnorScene");
                    break;
                case 2:
                    PhotonNetwork.LoadLevel("BridgeArea");
                    break;
                case 1:
                    PhotonNetwork.LoadLevel("Level1");
                    break;
                default:
                    PhotonNetwork.LoadLevel("Main");
                    break;
            }
        }
    }
}

