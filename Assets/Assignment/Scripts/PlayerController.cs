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

    void MovePlayer(float horizontalInput, float verticalInput)
    {
        // Calculate movement direction
        Vector3 moveDirection = new Vector3(horizontalInput, verticalInput, 0f);

        // Move the player based on input
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }

}
