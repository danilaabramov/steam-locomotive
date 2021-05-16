using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaxScore : MonoBehaviour
{
    private Text _text;

    public void Start()
    {
        _text = GetComponent<Text>();
    }

    public void Update()
    {
        _text.text =  PlayerPrefs.GetInt("Score").ToString();
    }
}