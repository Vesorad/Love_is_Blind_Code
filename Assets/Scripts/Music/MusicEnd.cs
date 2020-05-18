using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class MusicEnd : MonoBehaviour
{
    
   
    void Start()
    {

        Destroy(GameObject.Find("MusicPlayer"));
    }

   
    void Update()
    {
        
    }
}
