using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float playerSpeed = 10.0f;
    public float playerRotationSpeed = 100.0f;

    // Update is called once per frame
    void Update()
    {
        // Get horizontal and vertical axis with arrow keys
        // Multiply by delta time so it is per second and not per frame
        float translation = Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime;
        float rotation = Input.GetAxis("Horizontal") * playerRotationSpeed * Time.deltaTime;

        // Translate along the object's z-axis
        transform.Translate(0, 0, translation);

        //Rotate around y-axis
        transform.Rotate(0, rotation, 0);

    }
}
