using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private float speed;

	void Start ()
    {
        speed = 8;
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
    /// Método de colisão com objeto, utilizando para colidir com inimigo
    /// </summary>
    /// <param name="collision">Objeto que colide</param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
       if(collision.gameObject.tag == "Enemy")
        {
            speed = 0;
        }
    }
}
