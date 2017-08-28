using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Movetela1 : MonoBehaviour {

	public string Cena;	



	public void Trocar (){

		SceneManager.LoadScene (Cena);

	}
}

