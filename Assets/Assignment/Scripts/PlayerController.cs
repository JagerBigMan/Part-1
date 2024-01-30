using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    // Reference to the Rigidbody2D component
    private Rigidbody2D rb;

    void Start()
    {
        // Get the Rigidbody2D component on the player
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Get horizontal input
        float horizontalInput = Input.GetAxis("Horizontal");
        // Get vertical input
        float verticalInput = Input.GetAxis("Vertical");

        // Move the player based on input
        MovePlayer(horizontalInput, verticalInput);
    }

    void MovePlayer(float horizontalInput, float verticalInput)
    {
        // Calculate movement direction
        Vector2 moveDirection = new Vector2(horizontalInput, verticalInput);

        // Apply force to the player based on input
        rb.AddForce(moveDirection * moveSpeed);
    }
}
