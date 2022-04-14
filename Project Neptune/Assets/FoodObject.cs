using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodObject : MonoBehaviour
{
    public string[] Itemnames;
    string Foodname;
    // Start is called before the first frame update
    void Start()
    {
         Foodname = Itemnames[Random.Range(0, Itemnames.Length)];
        name = Foodname;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
