using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public float timeStart = 120;
    public Text textBox;
    public Text score;
    public float number;
    public Text highScore;
    
    // Start is called before the first frame update
    void Start()
    {
        textBox.text = timeStart.ToString("F1");
        highScore.text = PlayerPrefs.GetFloat("HighScore", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        timeStart -= Time.deltaTime;
        textBox.text = timeStart.ToString("F1");

        if (timeStart < PlayerPrefs.GetFloat("HighScore", 0) && Input.GetMouseButtonUp(0))
        {
            PlayerPrefs.SetFloat("HighScore", timeStart);
            highScore.text = timeStart.ToString("F1");
        }
    }
}
