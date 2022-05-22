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
    public int minT = 5;
    public int maxT = 10;

   
    private void Start()
    {
        rng = Random.Range(5, 10);

    }


    void Update()
    {
        time += Time.deltaTime;
        if(time >= rng)
        {
            PhotonNetwork.Instantiate(ball.name, this.transform.position, Quaternion.identity);
            time = 0;
         

        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(this.transform.position, radius);
    }
}
