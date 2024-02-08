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
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        
        gameOverScreen.SetActive(true);
    }
    public void StartGame()
    {

        
         StartScreen.SetActive(false);
        

    }
}
