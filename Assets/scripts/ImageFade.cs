using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ImageFade : MonoBehaviour {

	public Movetela1 mover;
	// the image you want to fade, assign in inspector
	public Image Image;

	public bool fadeIn = true;
	public bool fadeOnStart = false;

	public void Start(){
		if (fadeOnStart) {
			StartCoroutine (FadeImage ());
		}
	}


	public void OnButtonClick()
	{
		// fades the image out when you click
		StartCoroutine(FadeImage());
	}

	IEnumerator FadeImage()
	{
		// fade from opaque to transparent
		if (fadeIn)
		{
			// loop over 1 second backwards
			for (float i = 1; i >= 0; i -= Time.deltaTime)
			{
				// set color with i as alpha
				Image.color = new Color(0, 0, 0, i);
				yield return null;
			}
		}
		// fade from transparent to opaque
		else
		{
			// loop over 1 second
			for (float i = 0; i <= 1; i += Time.deltaTime)
			{
				// set color with i as alpha
				Image.color = new Color(0, 0, 0, i);
				yield return null;
			}
		}
		if (mover != null) {
			mover.Trocar ();
		}
	}
}