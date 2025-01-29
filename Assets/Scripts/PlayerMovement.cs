using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 playerMovementInput;
    private Vector2 playerMouseInput;

    [SerializeField] private Rigidbody rb;
    [Space]
    [SerializeField] private float movementSpeed;
    [SerializeField] private float sensitivity;
    [SerializeField] private float jumpForce;

    // Update is called once per frame
    void Update()
    {
        // Get player movement input
        playerMovementInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        // Get player mouse input for rotating character and camera
        playerMouseInput = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

        // Call player movement function
        MovePlayer();
    }

    private void MovePlayer()
    {
        // Scale the movement of the character by speed variable and make movement relative to the character's direction
        Vector3 moveDir = transform.TransformDirection(playerMovementInput) * movementSpeed;

        // Add velocity to rigidbody using the values from the player's input
        rb.velocity = new Vector3(moveDir.x, rb.velocity.y, moveDir.z);
        // Rotate character using mouseX
        transform.Rotate(0f, playerMouseInput.x * sensitivity, 0f);

        // Add jumping mechanic
        if (Input.GetButtonDown("Jump") && transform.position.y <= 1)
        {
            // Adds vertical upward force to rigidbody as an impulse (instant force)
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
