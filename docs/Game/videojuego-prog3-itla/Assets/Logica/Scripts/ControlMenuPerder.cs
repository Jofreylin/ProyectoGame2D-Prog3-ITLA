using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMenuPerder : MonoBehaviour
{
    public GameObject MenuPerder;


    public static bool jPerder = false;
    // Update is called once per frame
    void Update()
    {
            if (jPerder == true)
            {
                Pausa();
            }
            
    }
    void Pausa()
    {
        jPerder = true;
        Time.timeScale = 0f;

        MenuPerder.SetActive(true);
      
    }

  



    
}
