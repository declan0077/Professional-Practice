using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PortalScript : MonoBehaviour
{
    public int Level = 0;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            switch (Level)
            {
                case 4:
                    SceneManager.LoadScene("Bowling");
                    break;
                case 3:
                    SceneManager.LoadScene("ConnorScene");
                    break;
                case 2:
                    SceneManager.LoadScene("BridgeArea");
                    break;
                case 1:
                    SceneManager.LoadScene("Level1");
                    break;
                default:
                    SceneManager.LoadScene("Main");
                    break;
            }
        }
    }
}

