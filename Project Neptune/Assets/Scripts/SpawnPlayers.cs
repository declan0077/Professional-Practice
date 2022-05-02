using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;

public class SpawnPlayers : MonoBehaviourPunCallbacks

{


    public GameObject playerPrefab;

    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    private void Start()
    {

      
#if DEBUG
        PhotonNetwork.ConnectUsingSettings();
#else

        Vector2 randomPostion = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
        PhotonNetwork.Instantiate(playerPrefab.name, randomPostion, Quaternion.identity);
#endif 
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
    }
    public override void OnJoinedLobby()
    {
        PhotonNetwork.JoinRoom("TestRoom");
    }
    public override void OnJoinedRoom()
    {
        Vector3 randomPostion = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY));
        randomPostion += this.transform.position;
        PhotonNetwork.Instantiate(playerPrefab.name, randomPostion, Quaternion.identity);
    }

    public override void OnJoinRoomFailed(short returnCode,
        string message)
    {
        PhotonNetwork.CreateRoom("TestRoom");
    }
}
