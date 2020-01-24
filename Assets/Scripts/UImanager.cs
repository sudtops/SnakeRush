using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UImanager : MonoBehaviour
{
    public Text scoreText;
    public Text gameOverText;
    public GameObject restartButton;

    private bool gameOver;
    private int score;

    void Start()
    {
        gameOver = false;
        gameOverText.text = "";
        restartButton.SetActive(false);
        score = 0;
        UpdateScore();
    }

    public void AddScore(int newScoreValue = 10)
    {
        score += newScoreValue;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        gameOverText.text = "Game Over!";
        gameOver = true;
        restartButton.SetActive(true);
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
	    SceneManager.LoadScene(1);
    }
}
