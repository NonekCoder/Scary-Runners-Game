using UnityEngine;

public class PlayerTeleporter : MonoBehaviour
{
    public Transform playerTransform; // Reference to the player's transform
    public Vector3 teleportPosition; // The position to teleport the player to if they fall below Y -100
    private Rigidbody playerRigidbody; // Reference to the player's Rigidbody component

    // Start is called before the first frame update
    void Start()
    {
        // Get the player's Rigidbody component
        playerRigidbody = playerTransform.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTransform.position.y < -200f)
        {
            // Teleport the player to the specified position
            TeleportPlayer();
        }
    }

    // Method to teleport the player to a specific position
    void TeleportPlayer()
    {
        // Set the player's position to the teleport position
        playerTransform.position = teleportPosition;

        // Reset the player's velocity to ensure gravity affects them properly
        playerRigidbody.velocity = Vector3.zero;
    }
}
