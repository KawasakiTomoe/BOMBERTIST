using UnityEngine;
using System.Collections;

public class OAlScript : MonoBehaviour {

	public GameObject Al;
	public GameObject bomb;
	public GameObject Senkou; 

	// Use this for initialization
	void Start () {
		Al = GameObject.Find ("cube");
		bomb = GameObject.Find ("Explosion");
		Senkou = GameObject.Find ("senkou");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.name == "senkou") {
			Instantiate (bomb, transform.position, transform.rotation);
			Destroy (Senkou.gameObject);
			Destroy (this.gameObject);
		}
		Debug.Log(1);
	}
}
