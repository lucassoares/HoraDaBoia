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
        int vidaPlayer = Players.vida;
        if(vidaPlayer > 0){
            Players.vida -= 1;
        }
        else
        {
            Debug.Log("Morreu");
        }
        DestroyObject(this.gameObject);
    }
    
    /// <summary>
    /// Função da saída da colisão
    /// </summary>
    /// <param name="collision">Recebe o objeto</param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            speed = 0;
            collision.gameObject.GetComponent<Legumes>().colidiu = true;
            collision.gameObject.GetComponent<Legumes>().tirarVida++;
        }
    }

    /// <summary>
    /// Função de saída de colisão 
    /// </summary>
    /// <param name="collision">Objeto que o inimigo sairá da colisão</param>
    private void OnTriggerExit2D(Collider2D collision)
    {
      if(collision.gameObject.tag == "Player")
        {
            speed = -3;
        }
    }
}
