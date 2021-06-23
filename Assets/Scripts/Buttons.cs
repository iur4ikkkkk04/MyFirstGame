using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void NewGame()
    {
        //SceneManager.LoadScene("Game");
        Time.timeScale = 1F;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Game()
    {
        SceneManager.LoadScene("Game");
    }

    public void Close()
    {
        Application.Quit();
    }

    public void Menu()
    {
        Time.timeScale = 1F;
        SceneManager.LoadScene("Menu");
    }
}
