using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	void Start () {
		
	}
	
	void Update () {
        transform.Translate(8f * Time.deltaTime, 0, 0);
	}

    /// <summary>
    /// Destruindo objeto quando sai do foco da camera
    /// </summary>
    private void OnBecameInvisible()
    {
        DestroyObject(this.gameObject);
    }
}
