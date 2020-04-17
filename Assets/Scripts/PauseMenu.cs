using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
  public static bool GameIsPaused = false;
  public GameObject pauseMenuUI;

    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Escape))
      {
        if(GameIsPaused)
        {
          Resume();
        }
        else{
          Pause();
        }
      }

      else if (GameIsPaused && Input.GetKey("q")) {
        Debug.Log("Quitting Game");
          Application.Quit();
      }

      /*
      else if (GameIsPaused && Input.GetKey("m")) {
        Debug.Log("Going to Menu...");
        SceneManager.LoadScene("Menu");
      }
      */
    }

    public void Resume(){
      pauseMenuUI.SetActive(false);
      Time.timeScale = 1f;
      GameIsPaused = false;
    }

    void Pause(){
      pauseMenuUI.SetActive(true);
      Time.timeScale = 0f;
      GameIsPaused = true;
    }

    public void LoadMenu()
    {
      Debug.Log("Loading Menu...");
    }

    public void QuitGame()
    {
      Debug.Log("Quitting Game..");
    }
}
