using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        // Get horizontal input
        float horizontalInput = Input.GetAxis("Horizontal");
        // Get vertical input
        float verticalInput = Input.GetAxis("Vertical");

        // Move the player based on input
        MovePlayer(horizontalInput, verticalInput);
    }



}
