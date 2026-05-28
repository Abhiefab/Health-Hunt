using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    public CharacterController controller;

    [Header("Movement")]
    public float speed = 5f;

    [Header("Gravity")]
    public float gravity = -9.81f;

    Vector3 velocity;

    public Text healthText;

    float score = 10;

    void Update()
    {
        Move();

        if (score >= 100)
        {
            SceneManager.LoadScene("Complete");
        }
    }

    void Move()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        // Gravity
        if (controller.isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("health"))
        {
            score += 5;
            healthText.text = score.ToString();

            other.gameObject.SetActive(false);
        }

        if (other.gameObject.CompareTag("MainHealth"))
        {
            score += 10;
            healthText.text = score.ToString();

            other.gameObject.SetActive(false);
        }
    }
}