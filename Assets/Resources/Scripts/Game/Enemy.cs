﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float speed;
    private Abobora abobora = new Abobora();

    void Start ()
    {
        speed = -5;
    }
	
	void Update ()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }

    /// <summary>
    /// Método para destruir objetos quando saem da tela
    /// </summary>
    private void OnBecameInvisible()
    {
        DestroyObject(this.gameObject);
    }

    /// <summary>
    /// Método para detectar colisões
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            speed = 0;
            Abobora.colidiu = true;
        }
    }
}
