using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManagerScript : MonoBehaviour
{
    public GameObject gameOverUI;


    //public void Update()
   // {

        // Cursor.lockState = CursorLockMode.None;

     //   SetCursorLocked(true);
  //  }


    // When Player is killed UI is triggered aactive
    public void GameOver()
    {
        // Cursor.visible = true;
        SetCursorLocked(false);
        gameOverUI.SetActive(true);

        //GameManagerScript.SetCursorLocked(false); Use this if you call the function from outside the GameManagerScript - Finn

    }

    //If Restart button is clicked scene is reloaded
    public void Restart()
    {
        SetCursorLocked(true);
        SceneManager.LoadScene("GameArea");
    }

    // If Main menu button is clicked Player is taken back to main menu 
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
      
    }

    // If Quit button is clicked applicatin will close 
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    //From the main menu, if clicked will load game scene 
    public void StartGame()
    {
        SetCursorLocked(true);
        SceneManager.LoadScene("GameArea");
     
    }

    //If Control button is clicked loads scene where controls are shown

    public void Controls()
    {
        SceneManager.LoadScene("ControlsScene");
    }

    

  

    

    static public void SetCursorLocked(bool isLocked)
    {
        if (isLocked)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Debug.Log("Cursor is now locked!");
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
            Debug.Log("Cursor is no longer locked!");
        }
    }


    
}
