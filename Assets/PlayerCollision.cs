using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public GameObject gameOverUi;
    public Text scoreText;
    public GameObject score;
    public void NewGame()
    {
        score.SetActive(true);
        PlayerPrefs.SetInt("flag", 1);
        SceneManager.LoadScene(SceneManager.GetSceneAt(0).buildIndex);
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Finish"))
        {
            if(PlayerPrefs.GetInt("Score") < Convert.ToInt32(scoreText.text))
                PlayerPrefs.SetInt("Score", Convert.ToInt32(scoreText.text));
            PlayerPrefs.SetInt("ScorePrev", Convert.ToInt32(scoreText.text));
            gameOverUi.SetActive(true);
            score.SetActive(false);
            Time.timeScale = 0f;
        }
    }
}
