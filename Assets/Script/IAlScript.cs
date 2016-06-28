using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class IAlScript : MonoBehaviour {

	public GameObject IAl;
	public GameObject smoke;
	public GameObject fireworks; 
	public GameObject water;
	public GameObject pipetto;

	public Transform ePosition;

	public screenScript ss;

	public Text order;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "water") {
			order.text = " ";
			ss.StartAnimation ();
			Invoke ("ss.NextAnimation", 0.5f);
			Invoke("happend", 2.0f);
			Destroy (other.gameObject);
			Debug.Log(2);
		}
	}

	void happend() {
		Destroy (pipetto.gameObject);
		Instantiate (smoke, ePosition.position, transform.rotation);
		Debug.Log (3);
	}
}
