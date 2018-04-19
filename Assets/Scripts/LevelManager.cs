using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public float autoLoadNextLevelAfter;

    private void Start()
    {
        Invoke("LoadNextLevel", autoLoadNextLevelAfter);
        //Debug.Log("Start - LoadNextLevel");
    }


    public void LoadLevel(string name)
    {
        SceneManager.LoadScene(name);
     }

    public void LoadNextLevel()
    {
        //Debug.Log("before - LoadNextLevel");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //Debug.Log("after - LoadNextLevel");
    }

    public void Quit(string name)
    {
        Application.Quit();
    }

    public void OnApplicationQuit()
    {
        Application.Quit();
    }
}
