using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScene : MonoBehaviour
{
    public void GoToLevelSelect()
    {
        SceneManager.LoadScene("LevelSelect");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
