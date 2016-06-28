using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Nbutton : MonoBehaviour {

	public Image MainSpriteRenderer;
	public Sprite N;
	public Sprite N2;

	void start(){
		MainSpriteRenderer = gameObject.GetComponent<Image> ();
	}

	public void OnMouseOver(){
		MainSpriteRenderer.sprite = N;
	}

	public void OnMouseOut(){
		MainSpriteRenderer.sprite = N2;
	}
}