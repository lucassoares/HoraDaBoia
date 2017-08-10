using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private float speed;

	void Start ()
    {
        speed = 3;
	}
	
	void Update ()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
	}

    /// <summary>
    /// Destruindo objeto quando sai do foco da camera
    /// </summary>
    private void OnBecameInvisible()
    {
        DestroyObject(this.gameObject);
    }

    /// <summary>
    /// Método de entrar na colisão
    /// </summary>
    /// <param name="collision">Objeto de colisão</param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            speed = 0;
        }
    }
}
