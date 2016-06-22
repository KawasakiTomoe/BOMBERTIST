using UnityEngine;
using System.Collections;

public class OAlScript : MonoBehaviour {

	GameObject Al = GameObject.Find ("Sphere");
	GameObject dousen = GameObject.Find ("Capsule");
	GameObject bomb = GameObject.Find("Explosion");

	 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision other){
		Destroy (Al.gameObject);
		Destroy (dousen.gameObject);
		Instantiate (bomb, transform.position, transform.rotation);

	}
}
