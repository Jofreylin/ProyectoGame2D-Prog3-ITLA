using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMove : MonoBehaviour
{
    public float velocidad = 4f;
    public float maxY;
    public float minY;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        





        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * velocidad * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * velocidad * Time.deltaTime;

        }
   transform.position = new Vector3(transform.position.x,Mathf.Clamp(transform.position.y,minY,maxY), transform.position.z);
    }
}
