using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public GameObject pauseMenu;
    public GameObject optionsMenu;
    public bool isPaused;

    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject obj4;
    public GameObject obj5;
    public GameObject obj6;
    public GameObject obj7;
    public GameObject obj8;
    public GameObject obj9;




    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
        optionsMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            
        }
    }

    public void PauseGame()
    {
        optionsMenu.SetActive(false);
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;  
    }

    public void ResumeGame()
    {
        optionsMenu.SetActive(false);
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = false;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("A Player has Quit the Game");                                                 
    }

    public void Options()
    {
        optionsMenu.SetActive(true);

        obj1.SetActive(false);
        obj2.SetActive(false);
        obj3.SetActive(true);
        obj4.SetActive(true);
        obj5.SetActive(true);
        obj6.SetActive(false);
        obj7.SetActive(true);
        obj8.SetActive(false);
        obj9.SetActive(false);
        
    }
    

}
