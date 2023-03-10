using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseEvents : MonoBehaviour
{
    public GameObject pauseMenuScreen;

    public GameObject saveGame;
    public void PauseGame()
    {
        Time.timeScale = 0;
        pauseMenuScreen.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        pauseMenuScreen.SetActive(false);
    }

    public void SaveGame()
    {
        pauseMenuScreen.SetActive(false);
        saveGame.SetActive(true);
    }

    public void GoToMenu(int index)
    {
        SceneManager.LoadSceneAsync(index, LoadSceneMode.Single);
    }
}
