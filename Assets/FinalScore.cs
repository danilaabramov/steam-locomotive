using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public Text score;

    public Text finalText;
  
    public void Update()
    {
        finalText.text = "Score: " + PlayerPrefs.GetInt("ScorePrev");
    }
}
