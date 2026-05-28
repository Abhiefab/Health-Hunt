using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOverController : MonoBehaviour
{
    void Start()
    {
        // Show cursor in Game Over scene
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void replay()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void exitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}