using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverUI;

    public void TryAgain() {
        SceneManager.LoadScene("First Floor Scene");
    }

    public void Quit() {
        SceneManager.LoadScene("MainScreen");
    }
}
