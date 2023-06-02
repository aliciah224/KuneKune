using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManagerScript : MonoBehaviour
{
    public GameObject gameOverUI;

    public void Start()
    {
        
    }


    public void gameOver()
    {
        gameOverUI.SetActive(true);
        Cursor.lockState = CursorLockMode.None;

    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
    
}
