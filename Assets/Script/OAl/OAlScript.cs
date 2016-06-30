using UnityEngine;
using System.Collections;

  public class OAlScript : MonoBehaviour {

	public GameObject Al;
	public GameObject bomb;
	public GameObject Senkou; 

	public Animator order;

	// Use this for initialization
	void Start () {
		Invoke ("NextAnimation", 2.3f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.name == "fire") {
			Instantiate (bomb, transform.position, transform.rotation);
			Destroy (Senkou.gameObject);
			Destroy (this.gameObject);
		}
	}

	void NextAnimation(){
		order.SetTrigger ("switch");
	}
}
