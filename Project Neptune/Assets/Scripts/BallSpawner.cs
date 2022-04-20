using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class BallSpawner : MonoBehaviour
{
    public float time;
    public GameObject ball;
    private int rng;
    public int radius = 5;
    private void Start()
    {
        rng = Random.Range(2, 7);
    }


    void Update()
    {
        time += Time.deltaTime;
        if(time >= rng)
        {
            PhotonNetwork.Instantiate(ball.name, this.transform.position, Quaternion.identity);
            time = 0;
            rng = Random.Range(2, 7);

        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(this.transform.position, radius);
    }
}
