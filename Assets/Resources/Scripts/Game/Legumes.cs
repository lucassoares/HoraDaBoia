using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Legumes : MonoBehaviour
{
    private int vida;
    private float time;
    public bool colidiu;
    public int tirarVida;

    void Start ()
    {
        tirarVida = 0;
        colidiu = false;
        time = 0;
        vida = 15;	
	}
	
	void Update ()
    {
        if (colidiu)
        {
            time = time + 1 * Time.deltaTime;
            if(time >= 1)
            {
                vida -= tirarVida;
                time = 0;
            }
            if(vida <= 0)
            {
                DestroyObject(this.gameObject);
                Debug.Log("Legume morreu");
            }
        }	Debug.Log(colidiu + "asas" +  vida);
	}
}
