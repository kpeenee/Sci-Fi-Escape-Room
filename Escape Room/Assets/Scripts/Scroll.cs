using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    Material material;
    [SerializeField] float speed = 1.0f;
    Vector2 offsetChange;

    void Start()
    {
        material = GetComponent<Renderer>().material;
        offsetChange = new Vector2(speed, 0f);
        
    }

    // Update is called once per frame
    void Update()
    {
        material.mainTextureOffset += offsetChange * Time.deltaTime;
    }
}
