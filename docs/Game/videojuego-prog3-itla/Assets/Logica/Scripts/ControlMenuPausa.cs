using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMenuPausa : MonoBehaviour
{ 
    public GameObject MenuPausa;
   public static bool jpausa;
  
    void Start()
    {
        
    }

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

 void pausa(){

  jpausa = true;
            MenuPausa.SetActive(true);
            Time.timeScale = 0;


 }

 void quitarpausa(){


jpausa = false;
            MenuPausa.SetActive(false);
            Time.timeScale = 1;
    }
     
 }
}
