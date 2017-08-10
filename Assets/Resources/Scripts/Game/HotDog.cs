using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotDog : MonoBehaviour
{
    private int vida;
    public bool colidiu;
    private float time;

	void Start ()
    {
        vida = 10;
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
                vida-=2;
            }
            if(vida == 0)
            {
                Players.pontos += 5;
                DestroyObject(this.gameObject);
            }
        }
	}
}
