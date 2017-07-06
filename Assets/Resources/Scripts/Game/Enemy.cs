using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float speed;

    void Start ()
    {
        speed = 0;
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
}
