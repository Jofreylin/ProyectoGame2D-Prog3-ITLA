using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMenuPausa : MonoBehaviour
{
    public GameObject MenuPausa;
    public static bool jpausa = false;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            if (jpausa == true)
            {
                quitarpausa();
            }
            else
            {
                pausa();

            }
        }
    }
    void pausa()
    {

        jpausa = true;
        Time.timeScale = 0f;
        MenuPausa.SetActive(true);
        


    }

    void quitarpausa()
    {


        jpausa = false;
        Time.timeScale = 1f;
        MenuPausa.SetActive(false);
        
    }


}
