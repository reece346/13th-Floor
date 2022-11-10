using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Elevator : MonoBehaviour
{
    void OnTriggerEnter (Collider playerTouch) {
        SceneManager.LoadScene("SecondFloorScene");
    }
}
