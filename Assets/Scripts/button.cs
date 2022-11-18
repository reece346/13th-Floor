using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button : MonoBehaviour
{
    public Elevator elevator;
    void Update() {
        if(Input.GetMouseButtonDown(0)) {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit, 100.0f)) {
                if(hit.transform != null) {
                    if (hit.transform.gameObject.name == "Button" || hit.transform.gameObject.name == "Button (1)") {
                        elevator.elevatorButtonPressed();
                    }
                    PrintName(hit.transform.gameObject);
                }
            }
        }
    }

    private void PrintName(GameObject go) {
        print(go.name);
    }

}
