using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    //public ControlMove movement;
    public GameObject MenuPerder;
    public static bool jPerder = false;
    //public Bullet bullet;
    public ControlMenuPausa menuPausa;

    public void GameOver(){
        jPerder = true;
        MenuPerder.SetActive(true);
        Time.timeScale = 0f;
        //menuPausa.enabled = false;
    }

    public void Jugar(){
        menuPausa.enabled = true;
    }

}
