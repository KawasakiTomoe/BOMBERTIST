using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NIScript : MonoBehaviour {

	public GameObject NI;
	public GameObject hane;
	public GameObject fireworks; 
	public Animator order;
	public Animator back;

	// Use this for initialization
	void Start () {
		Invoke ("NextAnimation", 3.0f);

	}

	// Update is called once per frame
	void Update () {

	}

	void NextAnimation(){
		order.SetTrigger ("switch");
	}

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "hane") {
			Destroy (hane.gameObject);
			Destroy (this.gameObject);
			Instantiate (fireworks, transform.position, transform.rotation);
			Debug.Log (3);
			Invoke ("next", 1.0f);
		}
	}

	void next(){
		back.SetTrigger ("switch");
	}

	public void OnClick(){
		SceneManager.LoadScene ("MainSelection");
	}
		
}