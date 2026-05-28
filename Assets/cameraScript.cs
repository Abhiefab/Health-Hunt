using UnityEngine;

public class cameraScript : MonoBehaviour
{
    public float mouseSensitivity = 100f;

    public Transform playerBody;

    float xRotation = 0f;

    bool cameraActive = false;

    void Update()
    {
        // Click to activate camera
        if (Input.GetMouseButtonDown(0))
        {
            cameraActive = true;

            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        // Press ESC to unlock
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            cameraActive = false;

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

        // Don't rotate until clicked
        if (!cameraActive)
            return;

        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;

        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;

        xRotation = Mathf.Clamp(xRotation, -80f, 80f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        playerBody.Rotate(Vector3.up * mouseX);
    }
}