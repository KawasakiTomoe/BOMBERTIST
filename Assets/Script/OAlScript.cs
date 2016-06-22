using UnityEngine;
using System.Collections;

public class OAlScript : MonoBehaviour {

	public GameObject cup;
	public GameObject bomb;
	public GameObject box; 

	// Use this for initialization
	void Start () {
		cup = GameObject.Find ("Cylinder");
		bomb = GameObject.Find ("Explosion");
		box = GameObject.Find ("Cube");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.name == "Cube") {
			Instantiate (bomb, transform.position, transform.rotation);
			Destroy (box.gameObject);
			Destroy (cup.gameObject);
		}
		Debug.Log(1);
	}
}
