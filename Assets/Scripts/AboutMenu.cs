using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AboutMenu : MonoBehaviour
{
    public GameObject aboutMenuUI;

    public void Back() {
        SceneManager.LoadScene("MainScreen");
    }
}
