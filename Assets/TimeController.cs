using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
     float time = 150f;
    public Text timeText;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        timeText.text = Mathf.FloorToInt(time).ToString()+ "s";

        if(time <= 0)
        {
            time = 0;
            SceneManager.LoadScene("GameOver");
        }


    }
    
}
