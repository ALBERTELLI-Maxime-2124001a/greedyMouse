using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LaunchGame : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame()
    {
        SceneManager.LoadScene("Niveau1");
        Time.timeScale = 1.0f;
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
