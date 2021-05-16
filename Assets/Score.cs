using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public float scoreamount;

    public float pointincrease;

    public Text scoretext;

    public void Start()
    {
        scoreamount = 0;
        pointincrease = 10;
    }


    public void Update()
    {
        scoretext.text = (int)scoreamount + "";
        scoreamount += pointincrease * Time.deltaTime;
    }
}
