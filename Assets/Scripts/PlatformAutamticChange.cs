using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class PlatformAutamticChange : MonoBehaviour
{
    SpriteRenderer spriteRenderer;


    public Color blue;
    public Color pink;
    Light2D light;
    public float seconds = 1;
    


    void Start()
    {
        light = GetComponent<Light2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();    
        makePink();     
        StartCoroutine(ChangeColor());
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
    IEnumerator ChangeColor()
    {
        yield return new WaitForSeconds(seconds);
        if (gameObject.layer == 12)
        {
             makePink();

        }
        else if (gameObject.layer ==13)
        {
            makeBlue();
        }
        StartCoroutine(ChangeColor());
        
    }
}
