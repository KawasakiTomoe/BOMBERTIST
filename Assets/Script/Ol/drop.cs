using UnityEngine;
using System.Collections;

public class drop : MonoBehaviour {

	public GameObject water;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "water") {
			Destroy (other.gameObject);
		}
	}
}
