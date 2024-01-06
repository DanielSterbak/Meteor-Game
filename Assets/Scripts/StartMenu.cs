using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void GoToInstructions()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void GoToScoreBoard()
    {
        SceneManager.LoadScene("ScoreBoard");
    }
}