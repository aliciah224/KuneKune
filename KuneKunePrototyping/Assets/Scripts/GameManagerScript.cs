using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

}
