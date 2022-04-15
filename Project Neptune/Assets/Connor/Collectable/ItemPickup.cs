using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour , Collectable
{
    // Start is called before the first frame update
    public void collect()
    {
        Debug.Log("item Collected");
    }

    
}
