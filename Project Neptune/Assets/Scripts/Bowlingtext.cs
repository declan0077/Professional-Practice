using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Bowlingtext : MonoBehaviour
{

    public TextMeshPro ScoreTxt;
    public int score;

    void Update()
    {
        if(score < 10)
        {
            ScoreTxt.text = score.ToString() + "/" + "10";
        }
       
        if(score >= 10)
        {
            ScoreTxt.text = "Well done!";
        }
    }
}
