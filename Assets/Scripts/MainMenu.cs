using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenuUI;

    public void Play() {
        SceneManager.LoadScene("First Floor Scene");
    }

    public void About() {
        SceneManager.LoadScene("About Scene");
    }

    public void Instructions() {
        SceneManager.LoadScene("Instructions Scene");
    }

    public void Quit() {
        Application.Quit();
    }
}
