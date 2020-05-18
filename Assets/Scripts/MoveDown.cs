using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveDown : MonoBehaviour
{
    public float moveSpeed;
    public float rotationSpeed;
    public float posY;
    void Start()
    {
        StartCoroutine(Starte());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,- Time.deltaTime, 0, Space.World);
        transform.Rotate(Vector3.forward *rotationSpeed*  Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Application.Quit();
        }
    }
    IEnumerator  Starte()
    {
        yield return new WaitForSeconds(12);
        transform.position = new Vector3(posY, 3.75f, 0);
        StartCoroutine(Starte());

    }
}
