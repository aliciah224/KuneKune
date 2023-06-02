using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManagerScript : MonoBehaviour
{
    public GameObject gameOverUI;
    private bool GameScene = false;

    //When game is opened cursor can move
    public void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        {
           if (GameScene == true)

            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }


    // When Player is killed UI is triggered and Cursor can move again
    public void GameOver()
    {
        gameOverUI.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

    }

    //If Restart button is clicked scene is reloaded
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
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
      
        SceneManager.LoadScene("NewMapTest");
        GameScene = true;
        
       

        
    }

    

  

    


    
}
