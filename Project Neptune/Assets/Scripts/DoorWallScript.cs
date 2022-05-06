using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorWallScript : MonoBehaviour
{

    private Vector3 startPos;
    //adjust this to change speed
    [SerializeField]
    float speed = 5f;
    //adjust this to change how high it goes
    [SerializeField]
    float height = 1f;
    private Vector3 currentPos;
    private void Start()
    {
        startPos = this.transform.position;
    }
    void Update()
    {
        //get the objects current position and put it in a variable so we can access it later with less code
        Vector3 pos = transform.position;
        //calculate what the new Y position will be
        float newY = Mathf.Sin(Time.time * speed);
        //set the object's Y to the new calculated Y
        currentPos.x = startPos.x;
        currentPos.z = startPos.z;
        currentPos.y = startPos.y + newY * height;

        transform.position = currentPos;
    }

}
