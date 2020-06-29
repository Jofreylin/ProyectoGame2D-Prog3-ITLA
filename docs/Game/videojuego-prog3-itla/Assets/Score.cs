using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public static bool score = false;
    // Update is called once per frame
    void Update()
    {
        if(score){
            SumarScore();
        }
        
    }

    void SumarScore(){
        score = false;
        int cantidad = 0;
        int.TryParse(scoreText.text, out cantidad);
        cantidad = cantidad + 1;
        scoreText.text = cantidad.ToString();
    }
}

