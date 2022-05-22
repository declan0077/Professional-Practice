using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pinscript : MonoBehaviour
{
    public Bowlingtext text;
    public Vector3 startpos;
    public Transform rot;
    private void Start()
    {
        startpos = gameObject.transform.position;
        rot = gameObject.transform;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pin"))
        {
            other.gameObject.GetComponent<pinscript>().hit();
            text.score += 1;
            other.gameObject.tag = "dead";
            this.tag  = "dead";
            hit();
        }
      
    }
    public void hit()
    {
        StartCoroutine(Fade());
    }
    IEnumerator Fade()
    {
        yield return new WaitForSeconds(5f);
        this.transform.position = new Vector3(startpos.x, 0.561f, startpos.z);
        this.transform.rotation = rot.transform.rotation;
    }
}
