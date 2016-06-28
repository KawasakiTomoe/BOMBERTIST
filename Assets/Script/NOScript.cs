using UnityEngine;
using System.Collections;

public class NOScript : MonoBehaviour {

	public GameObject machi;
	public GameObject fire;
	public Animator element2;
	float flag = 0f;

	// Use this for initialization
	void Start () {
		element2 = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision other){
		if (other.gameObject.name == "machi") {
			flag = 1;
		}
	}

	void StartAnimation(){
		if (flag == 1f) {
			Instantiate (fire, transform.position, transform.rotation);
			element2.SetTrigger ("swich3");
		}
	}
}
