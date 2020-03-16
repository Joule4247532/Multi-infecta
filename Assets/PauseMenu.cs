using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool gamePaused = false;
    private bool optionsActive = false;

    public GameObject pauseMenuUI;
    public GameObject gameUI;
    public GameObject optionsUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseLink();
        }
    }
    public void PauseLink()
    {
        if (gamePaused)
        {
            Resume();
        }
        else
        {
            Pause();
        }
    }
    public void ResetTimeFreeze()
    {
        Time.timeScale = 1f;
    }

    private void Pause()
    {
        gameUI.SetActive(false);
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gamePaused = true;
    }

    private void Resume()
    {
        gameUI.SetActive(true);
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gamePaused = false;
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
    public void OptionsToggle()
    {
        if (!optionsActive)
        {
            pauseMenuUI.SetActive(false);
            optionsUI.SetActive(true);
            optionsActive = true;
        }
        else
        {
            pauseMenuUI.SetActive(true);
            optionsUI.SetActive(false);
            optionsActive = false;
        }
    }
}
