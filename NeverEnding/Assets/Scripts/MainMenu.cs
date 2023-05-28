using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject pauseMenu;
    public GameObject MainManu;
    public GameObject Op;
    public bool isPaused;

    public void Start()
    {
        MainManu.SetActive(true);
        Op.SetActive(false);
    }
    
    public void Play()
    {
        SceneManager.LoadScene("Game");
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = false;
    }

    public void Options()
    {
        Debug.Log("Coming Soon");
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("A Player has Quit the Game");                                                 
    }
 
}
