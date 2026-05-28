using UnityEngine;

public class IndoorGate : MonoBehaviour
{
    public Animator ani;

    bool playerNear = false;
    bool isOpen = false;

    void Update()
    {
        if (playerNear && !isOpen && Input.GetKeyDown(KeyCode.I))
        {
            isOpen = true;

            ani.SetTrigger("inDoor");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = false;
        }
    }
}