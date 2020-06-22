using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMenuPausa : MonoBehaviour
{
   public bool pausa = false;
   public GameObject MenuPausa;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("p") && pausa == false)
        {
            pausa = true;
            MenuPausa.active = true;
            Time.timeScale = 0;
        }
    else if (Input.GetKeyDown("p") && pausa == true)
    
    {
        pausa = false;
            MenuPausa.active = false;
            Time.timeScale = 1;
    }
    }
}
