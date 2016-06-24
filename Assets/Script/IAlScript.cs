using UnityEngine;
using System.Collections;

public class IAlScript : MonoBehaviour {

	public GameObject IAl;
	public GameObject smoke;
	public GameObject fireworks; 
	public GameObject water;
	public GameObject pipetto;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "water") {
			Invoke("happend", 2.0f);
			Destroy (other.gameObject);
			Debug.Log(2);
		}
	}

	void happend() {
		Destroy (pipetto.gameObject);
		Instantiate (smoke, transform.position, transform.rotation);
		Debug.Log (3);
	}
}
