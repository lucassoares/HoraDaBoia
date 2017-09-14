using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Players : MonoBehaviour
{
    public static int manas;
    public static int vida;
    public static int pontos;
    private float time;
    public Text manasText;
    public Text pontosText;
    public Canvas victoria;
    public Canvas derrota;


    void Start ()
    {
        pontos = 0;
        manas = 0;
        time = 0;
        vida = 15;
        victoria.enabled = false;
        derrota.enabled = false;
  
	}
	
	void Update ()
    {
        time = time + 1 * Time.deltaTime;
        if(time >= 1)
        {
            manas++;
            pontosText.text = vida.ToString();
            time = 0;
        }
        manasText.text = manas.ToString();

        if(pontos >= 100)
        {
            victoria.enabled = true;
        }
        if(vida <= 0)
        {
            derrota.enabled = true;
        }
    }

    public void BtnFechar()
    {
        derrota.enabled = false;
        victoria.enabled = false;
    }
}
