using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour
{
    public int speed = 5;
    Rigidbody Rb;
   public Vector3 rotation;
    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Rb.AddTorque(rotation * speed * Time.deltaTime);
    }
}
