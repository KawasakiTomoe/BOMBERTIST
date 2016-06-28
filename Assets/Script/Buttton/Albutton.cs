using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Albutton : MonoBehaviour {

	public Image MainSpriteRenderer;
	public Sprite Al;
	public Sprite Al2;

	void start(){
		MainSpriteRenderer = gameObject.GetComponent<Image> ();
	}

	public void OnMouseOver(){
		MainSpriteRenderer.sprite = Al;
	}

	public void OnMouseOut(){
		MainSpriteRenderer.sprite = Al2;
	}
}
