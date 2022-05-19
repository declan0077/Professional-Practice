using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishScript : MonoBehaviour
{
    public AudioSource Cheer;


    private IEnumerator coroutine;
   
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Cheer.Play();
            coroutine = WaitAndPrint(2.0f);
            StartCoroutine(coroutine);
        }
       
    }
    private IEnumerator WaitAndPrint(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene("Main");
    }
}
