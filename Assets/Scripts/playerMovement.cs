using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{
    public float playerSpeed;
    public Vector3 velocity;

    private Rigidbody rigidBod;

    public bool isKeyPressed = false;

    // Start is called before the first frame update
    void Start()
    {
        rigidBod = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isKeyPressed == false) {
            //Detect when the up arrow key is pressed down
            if (Input.GetKeyDown("w")) {
                Debug.Log("Up Arrow key was pressed.");
                isKeyPressed = true;
                movePlayer(Vector3.left);
                //movePlayer(Input.GetAxis("Vertical"), 0.0f);
            } else if (Input.GetKeyDown("s")) {
                Debug.Log("Down Arrow key was pressed.");
                isKeyPressed = true;
                movePlayer(Vector3.right);
                //movePlayer(Input.GetAxis("Vertical"), 0.0f);
            } else if (Input.GetKeyDown("a")) {
                Debug.Log("Left Arrow key was pressed.");
                isKeyPressed = true;
                movePlayer(Vector3.back);
                //movePlayer(0.0f, Input.GetAxis("Horizontal"));
            } else if (Input.GetKeyDown("d")) {
                Debug.Log("Right Arrow key was pressed.");
                isKeyPressed = true;
                movePlayer(Vector3.forward);
                //movePlayer(0.0f, Input.GetAxis("Horizontal"));
            }
        }
        //Detect when the up arrow key has been released
        if (Input.GetKeyUp("w")) {
            Debug.Log("Up Arrow key was released.");
            isKeyPressed = false;
            movePlayer(Vector3.zero);
        } else if (Input.GetKeyUp("s")) {
            Debug.Log("Down Arrow key was released.");
            isKeyPressed = false;
            movePlayer(Vector3.zero);
        } else if (Input.GetKeyUp("a")) {
            Debug.Log("Left Arrow key was released.");
            isKeyPressed = false;
            movePlayer(Vector3.zero);
        } else if (Input.GetKeyUp("d")) {
            Debug.Log("Right Arrow key was released.");
            isKeyPressed = false;
            movePlayer(Vector3.zero);
        }
    }

    public void movePlayer(Vector3 direction) {
        velocity = direction;
        rigidBod.velocity = new Vector3(velocity.x * playerSpeed, 0.0f, velocity.z * playerSpeed);
    }

    void OnTriggerEnter (Collider humanTouch) {
        // Check if the colliding object is the player
        if (humanTouch.gameObject.CompareTag("Enemy")) {
            SceneManager.LoadScene("GameOverScreen");
        }
    }
}
