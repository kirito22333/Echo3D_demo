using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class timer : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI timerText;
    private float startTime;
    private bool finished = false;

    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(finished)
            return;

        float t = Time.time -startTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        timerText.text = minutes + ":" + seconds; 
    }

    public void Finish(){
        finished = true;
        PlayerPrefs.SetString("time", timerText.text);
    }
}
