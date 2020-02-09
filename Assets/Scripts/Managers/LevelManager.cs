using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public string menuScene;
    public string firstLevel;
    public string currentScene;
    public string nextScene;

    public void StartNewGame()
    {
        Debug.Log("Starting the game!");
        SceneManager.LoadScene(firstLevel);
    }

    //public void OpenTip()
    //{
    //    Debug.Log("We don't have tips yet!");
    //}   
    
    public void LoadNextLevel()
    {
        Debug.Log("Loading next level");
        SceneManager.LoadScene(nextScene);
    }
   
    public void LoadMainMenu()
    {
        Debug.Log("Restart level");
        SceneManager.LoadScene(menuScene);
        Destroy(GameObject.FindGameObjectWithTag("MainAudioSource"));
    }

    //public void LoadArena()
    //{
    //    Debug.Log("We don't have Arena yet!");
    //}

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    
}
