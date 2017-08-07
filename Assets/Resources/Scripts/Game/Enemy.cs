using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float speed;
    private Abobora abobora = new Abobora();

    void Start ()
    {
        speed = -3;
    }
	
	void Update ()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }

    /// <summary>
    /// Método quando saem da tela
    /// </summary>
     void OnBecameInvisible()
    {
        Players.vida -= 3;
        Debug.Log(Players.vida);
        DestroyObject(this.gameObject);
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            speed = 0;
            collision.gameObject.GetComponent<Legumes>().colidiu = true;
            collision.gameObject.GetComponent<Legumes>().tirarVida++;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
      if(collision.gameObject.tag == "Player")
        {
            speed = -5;
        }
    }
}
