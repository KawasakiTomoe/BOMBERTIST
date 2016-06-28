using UnityEngine;
using System.Collections;

public class screenScript : MonoBehaviour {

	public Animator element;

	// Use this for initialization
	void Start () {
		element = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	public void StartAnimation () {
		element.SetTrigger ("swich2");
	}

	public void NextAnimation(){
		element.SetTrigger ("swich1");
	}
}
