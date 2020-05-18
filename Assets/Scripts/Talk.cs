using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Talk : MonoBehaviour
{
    public Animator animator;
    public Image textBox;
    public TextMeshProUGUI text;
    public string text2;
    public float[] time;

    private float timeNextScene = 10f;

    private void Start()
    {
        
        StartCoroutine(WaitAndTalk1());
        StartCoroutine(StopTalk1());
        StartCoroutine(WaitAndTalk2());
        StartCoroutine(StopTalk2());
        StartCoroutine(StartGame());
    }
    IEnumerator WaitAndTalk1()
    {
        yield return new WaitForSeconds(time[0]);
        textBox.color = new Color(255, 255, 255, 1);
        text.color = new Color(0, 0, 0, 1);
       // animator.SetBool("Talk", true);
        
    }
    IEnumerator StopTalk1()
    {
        yield return new WaitForSeconds(time[1]);
        textBox.color = new Color(255, 255, 255, 0);
        text.color = new Color(0, 0, 0, 0);
        //animator.SetBool("Talk", false);
    }
    IEnumerator WaitAndTalk2()
    {
        yield return new WaitForSeconds(time[2]);
        textBox.color = new Color(255, 255, 255, 1);
        text.color = new Color(0, 0, 0, 1);
        text.text = text2;
       // animator.SetBool("Talk", true);

    }
    IEnumerator StopTalk2()
    {
        yield return new WaitForSeconds(time[3]);
        textBox.color = new Color(255, 255, 255, 0);
        text.color = new Color(0, 0, 0, 0);
       // animator.SetBool("Talk", false);
    }
    IEnumerator StartGame()
    {
        yield return new WaitForSeconds(timeNextScene);
        SceneManager.LoadScene(1);
    }
}
