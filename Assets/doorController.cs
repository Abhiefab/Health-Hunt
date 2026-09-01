using UnityEngine;

public class doorController : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Animator ani;
    public AudioSource doorSound;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            ani.SetTrigger("Door");
            doorSound.Play();
        }

    }
}
