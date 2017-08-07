using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Players : MonoBehaviour
{
    public static int manas;
    public static int vida;
    private float time;
    public Text manasText;
    public Text pontosText;

    void Start ()
    {
        manas = 0;
        time = 0;
        vida = 15;
	}
	
	void Update ()
    {
        time = time + 1 * Time.deltaTime;

        if(time >= 1)
        {
            manas++;
            time = 0;
        }

        manasText.text = manas.ToString();
        pontosText.text = vida.ToString();
    }
}
