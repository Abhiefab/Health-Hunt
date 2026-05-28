using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    public CharacterController controller;

    [Header("Movement")]
    public float speed = 5f;
    public Text healthText;

    float score = 10;

    void Update()
    {
        Move();
    }

    void Move()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("health"))
        {
            score = score + 5;
            healthText.text = score.ToString();

            other.gameObject.SetActive(false);

            Debug.Log(score);
        }
        if (other.gameObject.CompareTag("MainHealth"))
        {
            score = score + 10;
            healthText.text = score.ToString();

            other.gameObject.SetActive(false);

            Debug.Log(score);
        }
    }
}