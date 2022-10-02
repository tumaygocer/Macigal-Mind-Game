using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomePageControl : MonoBehaviour
{
    public GameObject ExitPanel;

    private void Start()
    {
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }       
    }
    public void GameExit()
    {       
        ExitPanel.SetActive(true);
    }

    public void Reply(string reply)
    {
        
        if (reply == "Yes")
        {
            Application.Quit();
        }
        else
        {
            ExitPanel.SetActive(false);
        }

    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
