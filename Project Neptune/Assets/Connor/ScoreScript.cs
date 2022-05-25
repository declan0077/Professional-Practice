using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ScoreScript : MonoBehaviour
{
    public TextMeshPro MyScoretext;
    private int ScoreNum;
    public GameObject Wall;
    private ParticleSystem PS;
    private AudioSource AS;

    // Start is called before the first frame update
    void Start()
    {
        ScoreNum = 0;
        MyScoretext.text = "Hoops Scored " + ScoreNum;
        PS = GetComponent<ParticleSystem>();
        AS = GetComponent<AudioSource>();
    }
    private void Update()
    {
        if (ScoreNum <= 1)
        {
            Wall.GetComponent<Animator>().Play("WallMove", -1, 0f);
        }


    }

    private void OnTriggerEnter(Collider Ball)
    {
        if (Ball.tag == "Ball")
        {
            ScoreNum += 2;
            MyScoretext.text = "Score" + ScoreNum;
            PS.Play();
            AS.Play();

        }
       
        
    }
}
