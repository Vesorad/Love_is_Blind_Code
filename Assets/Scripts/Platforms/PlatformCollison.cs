using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Experimental.Rendering.Universal;

public class PlatformCollison : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    

    public Color blue;
    public Color pink;
    Light2D light;

    
    void Start()
    {
        light = GetComponent<Light2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void makeBlue()
    {
        light.enabled = true;
        light.color = blue;
        spriteRenderer.color = blue;
        gameObject.layer = 12;
    }
    void makePink()
    {
        light.enabled = true;
        light.color = pink;
        spriteRenderer.color = pink;
        gameObject.layer = 13;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            makeBlue();
        }
        if (collision.gameObject.layer == 9)
        {
            makePink();
        }
        
    }
   

}
