using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Sobre : MonoBehaviour {

    public Canvas instru;
    public Canvas sobre;
    

	void Start () {
        instru.enabled = false;
        sobre.enabled = false;	
	}
	
	void Update () {
		
	}

    public void openAbout()
    {
        sobre.enabled = true;
    }
    public void openInstru()
    {
        instru.enabled = true;
    }

    public void CloseAbout()
    {
        sobre.enabled = false;
    }

    public void CloseInstru()
    {
        instru.enabled = false;
    }
}
