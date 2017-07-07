using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abobora : MonoBehaviour
{
    private int vida;
    public static bool colidiu;
    private float time;

    void Start ()
    {
        vida = 15;
        colidiu = false;
        time = 0;
	}
	
	void Update ()
    {
        if (colidiu)
        {
            time = time + 1 * Time.deltaTime;
            if(time > 1)
            {
                time = 0;
                vida--;
            }
        }

        if(vida == 0)
        {
            DestroyObject(this.gameObject);
            Debug.Log("Morreu");
        }

        Debug.Log("Vida da abobora: " + vida + colidiu);
	}
}
