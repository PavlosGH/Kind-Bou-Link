using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeToScene : MonoBehaviour
{
    public void LoadMainMenuScene()
    {
        SceneManager.LoadScene(0);
    }
    public void LoadGameGuidelinesScene()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadFirstScene()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadSecondScene()
    {
        SceneManager.LoadScene(4);
    }

    public void LoadThirdScene()
    {
        SceneManager.LoadScene(6);
    }
}
