using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScreen : MonoBehaviour
{
    
    public void Setup(){
        gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void ContinueButton(){
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void MainMenuButton(){
        SceneManager.LoadScene("MainMenu");
    }
}
