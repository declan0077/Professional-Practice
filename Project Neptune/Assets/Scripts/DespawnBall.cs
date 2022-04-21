using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnBall : MonoBehaviour
{
    public float time;
    void Update()
    {
        time += Time.deltaTime;
        if (time >= 10f)
        {
            Destroy(this.gameObject);
            time = 0;
        }
    }
}
