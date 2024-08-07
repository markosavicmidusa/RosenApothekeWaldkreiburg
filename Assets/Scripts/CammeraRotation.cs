using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float rotationSpeed = 100f; // Adjust rotation speed as needed
    public Transform player;

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;

        player.Rotate(Vector3.up, mouseX);
        
        // Optionally, uncomment the following line to rotate the camera vertically
        transform.RotateAround(player.position, transform.right, -mouseY);
    }
}
