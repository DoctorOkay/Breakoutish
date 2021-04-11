using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("BlockBreaker", LoadSceneMode.Single);
    }

    public void LoadGameOver()
    {
        SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
    }
}
