using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust movement speed as needed

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(-verticalInput, 0f, horizontalInput).normalized;
        transform.position += transform.TransformDirection(moveDirection) * moveSpeed * Time.deltaTime;
    }
}
