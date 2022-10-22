using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Display : MonoBehaviour
{
    public TextMeshProUGUI timerText;

    // Start is called before the first frame update
    void Start()
    {
        timerText.text = "Time Spent: " + PlayerPrefs.GetString("time");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
