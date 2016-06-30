using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class onfireScript : MonoBehaviour {

	public GameObject fire;

	// Use this for initialization
	void Start () {
		fire.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision other){
		if (other.gameObject.name == "touch") 
			fire.SetActive(true);
	}
}
