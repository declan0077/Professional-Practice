using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text MyScoretext;
    private int ScoreNum;


    // Start is called before the first frame update
    void Start()
    {
        ScoreNum = 0;
        MyScoretext.text = "Score" + ScoreNum;
    }

    private void OnTriggerEnter(Collider Ball)
    {
        if (Ball.tag == "Ball")
        {
            ScoreNum += 1;
            MyScoretext.text = "Score" + ScoreNum;

       

        }
        if (ScoreNum == 1) 

        {
            
        }
    }
}
