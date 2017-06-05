using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BottomMenuScript : MonoBehaviour {
    public Canvas leftMenu;
    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject spawn3;

    public GameObject cenoura;
    public GameObject abobora;
    public GameObject tomate;
    public GameObject brocolis;

    private GameObject personagemEscolhido;
   
	void Start (){
        leftMenu.enabled = false;
	}
	
	void Update (){}

    public void firstArrowClick()
    {
        Instantiate(personagemEscolhido, spawn1.transform.position, spawn1.transform.rotation);
    }

    public void secondArrowClick()
    {
        Instantiate(personagemEscolhido, spawn2.transform.position, spawn2.transform.rotation);
    }

    public void thirdArrowClick()
    {
        Instantiate(personagemEscolhido, spawn3.transform.position, spawn3.transform.rotation);
    }

    public void clickCenoura()
    {
        leftMenu.enabled = true;
        personagemEscolhido = cenoura;
    }
    public void clickAbobora()
    {
        leftMenu.enabled = true;
        personagemEscolhido = abobora;
    }
    public void clickBrocolis()
    {
        leftMenu.enabled = true;
        personagemEscolhido = brocolis;
    }
    public void clickTomate()
    {
        leftMenu.enabled = true;
        personagemEscolhido = tomate;
    }
}
