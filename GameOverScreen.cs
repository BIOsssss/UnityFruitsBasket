using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public Text pointsText;
    public void Setup(int score){
        gameObject.SetActive(true);
        pointsText.text = "SCORE: " + score;
        Time.timeScale = 0;
    }
    public void RestartButton(){
        SceneManager.LoadScene("Game");
        Time.timeScale = 1;
    }

    public void MainMenuButton(){
        SceneManager.LoadScene("MainMenu");
    }
}
