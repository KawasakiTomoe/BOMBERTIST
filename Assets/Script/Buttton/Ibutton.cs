using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Ibutton : MonoBehaviour {

	public Image MainSpriteRenderer;
	public Sprite I;
	public Sprite I2;

	void start(){
		MainSpriteRenderer = gameObject.GetComponent<Image> ();
	}

	public void OnMouseOver(){
		MainSpriteRenderer.sprite = I;
	}

	public void OnMouseOut(){
		MainSpriteRenderer.sprite = I2;
	}
}