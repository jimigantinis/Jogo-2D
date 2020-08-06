using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public static int noAmmo;    

    void Update()
    {
        if (Bow.currentAmmo==0 && Bow2.currentAmmo==0)
        {
           if (GameIsPaused)
            {
                if (Bow.currentAmmo>0 || Bow2.currentAmmo>0)
                {
                    Resume();
                }
            } else
            {
                Pause();
            } 
        }
        if (Bow.currentAmmo>0 || Bow2.currentAmmo>0)
        {
            Resume();
        }
    }

    public void Resume ()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause ()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Debug.Log("Saindo do Jogo...");
        Application.Quit();
    }
}
