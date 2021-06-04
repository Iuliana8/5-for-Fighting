using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Button newGameButton;

    public Button exitGameButton;

    public string newGameSceneName;

    public void Awake()
    {
        newGameButton.onClick.AddListener(NewGame);
        exitGameButton.onClick.AddListener(ExitGame);
    }

    public void NewGame()
    {
        SceneManager.LoadScene(newGameSceneName);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
