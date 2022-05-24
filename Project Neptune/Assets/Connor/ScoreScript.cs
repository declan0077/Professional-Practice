using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text MyScoretext;
    private int ScoreNum;
    public GameObject Wall;

    // Start is called before the first frame update
    void Start()
    {
        ScoreNum = 0;
        MyScoretext.text = "Score" + ScoreNum;
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

       

        }
       
        
    }
}
