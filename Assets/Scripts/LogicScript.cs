using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public GameObject StartScreen;
    

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore+=scoreToAdd;
        scoreText.text=playerScore.ToString();
    }

    public void ResetGame()
    {
        Time.timeScale = 1.0f;//unfreezing when the player
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        
        Time.timeScale = 0f;//freezing the game when the player dies
        gameOverScreen.SetActive(true);
    }
    public void StartGame()
    {
         StartScreen.SetActive(false);
    }
}
