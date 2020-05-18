using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndPlatform : MonoBehaviour
{
    
    public bool hasBlue;
    public bool hasPink;

    public ResetGame resetGame;



    public PlayerMovment2 playerMovment2;
    
    
    void Start()
    {
        
        
    }

    
    void Update()
    {
        if (hasPink == true && hasBlue == true)
        {
            MakeGreed();
        }
    }
    void MakeGreed()
    {
        playerMovment2.HasMovment = false;
        StartCoroutine(NextScene());
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 14)
        {
            hasBlue = true;
        }
        if (collision.gameObject.layer == 15)
        {
            hasPink = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 14)
        {
            hasBlue = false;
        }
        if (collision.gameObject.layer == 15)
        {
            hasPink = false;
        }
    }
    IEnumerator NextScene()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(resetGame.ActtualScene + 1);

    }
   
}
