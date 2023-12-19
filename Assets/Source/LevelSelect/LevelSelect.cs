using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public void GoToLevelOne()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void GoToLevelTwo()
    {
        SceneManager.LoadScene("LevelTwo");
    }
    public void GoToLevelThree()
    {
        SceneManager.LoadScene("LevelThree");
    }
    public void QuitFromApp()
    {
        Application.Quit();
    }
}
