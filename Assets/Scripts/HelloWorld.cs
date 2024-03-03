using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Hello_World : MonoBehaviour
{
    public int counter = 0;
    public int speed = 10;
    public GameObject helloText;
    // Start is called before the first frame update
    void Start()
    {
        print("Hello World");
        helloText.GetComponent<TextMeshPro>().text = "Hello World";
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed);
    }
}
