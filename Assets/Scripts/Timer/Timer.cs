using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float startTime;
    
    void Start()
    {
        SetUpSingleton();
        startTime = Time.time;
    }
    private void SetUpSingleton()
    {
        int numberGameSession = FindObjectsOfType<TimerStay>().Length;
        if (numberGameSession > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Pink_Talk_1") != null)
        {
           
        }
        else
        {
            float t = Time.time - startTime;

            string minutes = ((int)t / 60).ToString();
            string seconds = (t % 60).ToString("f1");

            timerText.text = minutes + ":" + seconds;
        }
        
    }
}
