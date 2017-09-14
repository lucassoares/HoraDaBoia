using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Parallax : MonoBehaviour {
	public RawImage image;
	public float speed; 
	Rect rect ; 

	// Use this for initialization
	void Start () { 


	}

	// Update is called once per frame
	void Update () {

		rect = image.uvRect; 
		rect.x += speed * Time.deltaTime; 
		image.uvRect = rect; 



	}
}
