using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WebcamScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        WebCamTexture webCamTexture = new WebCamTexture();
        Renderer renderer = GetComponent<Renderer>();

        renderer.material.mainTexture = webCamTexture;
        webCamTexture.Play();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
