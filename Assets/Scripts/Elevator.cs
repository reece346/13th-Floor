using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Elevator : MonoBehaviour
{
    public string FloorToGo;

    public int elevatorButtonsPressed = 0;
    public int totalElevatorButtons;

    public bool elevatorOpen = false;

    

    void Update() {
        if(elevatorButtonsPressed == totalElevatorButtons) {
            elevatorOpen = true;
        }

    }

    public void elevatorButtonPressed () {
        elevatorButtonsPressed++;
    }
    
    void OnTriggerEnter (Collider playerTouch) {
        if(elevatorOpen) {
            SceneManager.LoadScene(FloorToGo);
        }
        
    }
}
