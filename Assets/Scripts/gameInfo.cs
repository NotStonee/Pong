using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameInfo : MonoBehaviour 
{
    public int player1Score;
    public int player2Score;
    public Text player1ScoreText;
    public Text player2ScoreText;

    public void addPlayer1Score() 
    {
      player1Score++;
      player1ScoreText.text = player1Score.ToString();
    }

    public void addPlayer2Score() 
    {
      player2Score++;
      player2ScoreText.text = player2Score.ToString();
    }

    public void restartGame() 
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    
}
