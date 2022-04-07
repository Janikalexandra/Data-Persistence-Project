using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    public string highscoreText;
    public string playerName;

    public Text playerNameText;

    private void Start()
    {
        playerNameText.text = DataManager.Instance.playerName + ": " + DataManager.Instance.playerScore;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
