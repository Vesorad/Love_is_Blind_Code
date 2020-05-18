using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetGame : MonoBehaviour
{ 
    public int ActtualScene;
    

    public void Reset()
    {

        SceneManager.LoadScene(ActtualScene);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer ==8)
        {
            Reset();
        }
        else if (collision.gameObject.layer == 9)
        {
            Reset();
        }
    }
  
}
