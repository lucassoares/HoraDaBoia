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

    private GameObject personagemEscolhido;

    private Players player = new Players();

	void Start ()
    {
        leftMenu.enabled = false;
	}
	
	void Update ()
    {
        
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
        ClickBottomMenu(cenoura);
    }

    /// <summary>
    /// Metodo de clique na abobora
    /// </summary>
    public void clickAbobora()
    {
        if(Players.manas >= 5)
        {
            ClickBottomMenu(abobora);
            Players.manas -= 5;
        }
        else
        {
            Debug.Log("Você ainda não pode utilizar este personagem");
        }
    }

    /// <summary>
    /// Metodo de clique no brocolis
    /// </summary>
    public void clickBrocolis()
    {
        ClickBottomMenu(brocolis);
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
