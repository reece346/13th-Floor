using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float playerSpeed;
    public Vector3 velocity;

    private Rigidbody rigidBod;

    // Start is called before the first frame update
    void Start()
    {
        rigidBod = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Double If statment only allows for 4 directions (forward, left, right, backward)
        if (Input.GetAxis("Vertical") != 0.0f) {
            // either forward or backwards is being read
            movePlayer(Input.GetAxis("Vertical"), 0.0f);
        } else if (Input.GetAxis("Horizontal") != 0.0f) {
            //either left or right is being read
            movePlayer(0.0f, Input.GetAxis("Horizontal"));
        }
    }

    public void movePlayer(float moveVertical, float moveHorizontal) {
        Vector3 translation;

        // Updates the values needed to translate the player
        translation = moveVertical * rigidBod.transform.forward;
        translation += moveHorizontal * rigidBod.transform.right;
        translation.y = 0;

        if (translation.magnitude > 0.2f) {
            velocity = translation;
        } else {
            velocity = Vector3.zero;
        }

        // Update the velocity
        rigidBod.velocity = new Vector3(velocity.normalized.x * playerSpeed, 0.0f, velocity.normalized.z * playerSpeed);
    }
}
