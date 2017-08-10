using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BottomMenuScript : MonoBehaviour
{
    public Canvas leftMenu;

    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject spawn3;

    public GameObject cenoura;
    public GameObject abobora;
    public GameObject tomate;
    public GameObject brocolis;

    public Image aboboraInferior;
    public Image cenouraInferior;
    public Image brocolisInferior;

    private GameObject personagemEscolhido;

    private Players player = new Players();

	void Start ()
    {
        leftMenu.enabled = false;
	}
	
	void Update ()
    {
        if(Players.manas <= 10)
        {
            aboboraInferior.GetComponent<Button>().interactable = false;
        }
        else
        {
            aboboraInferior.GetComponent<Button>().interactable = true;
        }

        if(Players.manas <= 5)
        {
            brocolisInferior.GetComponent<Button>().interactable = false;
            cenouraInferior.GetComponent<Button>().interactable = false;
        }
        else
        {
            brocolisInferior.GetComponent<Button>().interactable = true;
            cenouraInferior.GetComponent<Button>().interactable = true;
        }
    }

    /// <summary>
    /// Metodo de clique primeira seta
    /// </summary>
    public void firstArrowClick()
    {
        InstantiateObject(spawn1);
    }

    /// <summary>
    /// Metodo de clique segunda seta
    /// </summary>
    public void secondArrowClick()
    {
        InstantiateObject(spawn2);
    }

    /// <summary>
    /// Metodo de clique terceira seta
    /// </summary>
    public void thirdArrowClick()
    {
        InstantiateObject(spawn3);
    }

    /// <summary>
    /// Metodo de clique na cenoura
    /// </summary>
    public void clickCenoura()
    {
        if (Players.manas >= 5)
        {
            ClickBottomMenu(cenoura);
            Players.manas -= 5;
        }
    }

    /// <summary>
    /// Metodo de clique na abobora
    /// </summary>
    public void clickAbobora()
    {
        if(Players.manas >= 10)
        {
            ClickBottomMenu(abobora);
            Players.manas -= 10;
        }
    }

    /// <summary>
    /// Metodo de clique no brocolis
    /// </summary>
    public void clickBrocolis()
    {
        if (Players.manas >= 5)
        {
            ClickBottomMenu(brocolis);
            Players.manas -= 5;
        }
    }

    /// <summary>
    /// Metodo de clique no tomate
    /// </summary>
    public void clickTomate()
    {
        ClickBottomMenu(tomate);
    }

    /// <summary>
    /// Metodo para instanciar objeto na posição do menu
    /// </summary>
    /// <param name="position">Recebe a posição do spawn</param>
    private void InstantiateObject(GameObject position)
    {
        Instantiate(personagemEscolhido, position.transform.position, position.transform.rotation);
        leftMenu.enabled = false;
    }
    
    /// <summary>
    /// Metodo de escolha de personagem para instanciar
    /// </summary>
    /// <param name="personagem">Personagem do selecionado no menu</param>
    private void ClickBottomMenu(GameObject personagem)
    {
        leftMenu.enabled = true;
        personagemEscolhido = personagem;
    }
}
