using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Obutton : MonoBehaviour {

	public Image MainSpriteRenderer;
	public Sprite O;
	public Sprite O2;

	void start(){
		MainSpriteRenderer = gameObject.GetComponent<Image> ();
	}

	public void OnMouseOver(){
		MainSpriteRenderer.sprite = O;
	}

	public void OnMouseOut(){
		MainSpriteRenderer.sprite = O2;
	}
}