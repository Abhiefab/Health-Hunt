using UnityEngine;

public class gameComplete : MonoBehaviour
{
    void Start()
    {
        // Show cursor in complete/menu scene
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}