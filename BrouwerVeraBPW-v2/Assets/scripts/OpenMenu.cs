using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenMenu : MonoBehaviour
{

 void Start(){
    Cursor.lockState = CursorLockMode.None;
    Cursor.visible = true;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
        
    public void QuitGame()
    {
        Debug.Log("Sterf game, sterf");
       Application.Quit(); 
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
        
    }
}
