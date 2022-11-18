using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HumanMovement : MonoBehaviour
{
    public float humanSpeed;
    public Vector3 velocity;

    private Rigidbody rigidBod;

    public Elevator elevator;

    public string activeScene;

    public string humanNumber;
    public float timer0, timer1, timer3, timer4 = 1;

    // Start is called before the first frame update
    void Start()
    {
        rigidBod = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {

        timer0++;
        timer1++;
        timer3++;
        timer4++;

        if (humanNumber == "human0") {
            if (timer0 <= 1000) {
                moveHuman(Vector3.right);
            } else if (timer0 > 1000 && timer0 < 2000) {
                moveHuman(Vector3.left);
            } else {
                timer0 = 0;
            }
        }
        if (humanNumber == "human1") {
            if (timer1 <= 1500) {
                moveHuman(Vector3.back);
            } else if (timer1 > 1500 && timer1 < 3000) {
                moveHuman(Vector3.forward);
            } else {
                timer1 = 0;
            }
        }
        if (humanNumber == "human3") {
            if (timer3 <= 1500) {
                moveHuman(Vector3.forward);
            } else if (timer3 > 1500 && timer3 < 3000) {
                moveHuman(Vector3.back);
            } else {
                timer3 = 0;
            }
        }
        if (humanNumber == "human4") {
            if (timer4 <= 1500) {
                moveHuman(Vector3.back);
            } else if (timer4 > 1500 && timer4 < 3000) {
                moveHuman(Vector3.forward);
            } else {
                timer4 = 0;
            }
        }
    }

    void OnTriggerEnter (Collider playerTouch) {
        elevator.elevatorButtonsPressed = 0;
        //player.position.x = 10;
        //player.position.y = 2.3;
        //player.position.z = 12;
    }

    public void moveHuman(Vector3 direction) {
        velocity = direction;
        rigidBod.velocity = new Vector3(velocity.x * humanSpeed, 0.0f, velocity.z * humanSpeed);
    }

    
}
