using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IAlScript : MonoBehaviour {

	public GameObject IAl;
	public GameObject smoke;
	public GameObject fireworks; 
	public GameObject water;
	public GameObject pipetto;
	public GameObject eP;
	public Animator order;
	public Animator backbutton;

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
		if (other.gameObject.tag == "water") {
			Invoke("happend", 2.0f);
			Invoke ("firework", 4.0f);
			Destroy (other.gameObject);
			Debug.Log(2);
		}

		Invoke ("back", 9.0f);
	}

	void happend() {
		Destroy (pipetto.gameObject);
		Instantiate (smoke, transform.position, transform.rotation);
		Debug.Log (3);
	}

	void back(){
		backbutton.SetTrigger ("switch");
	}

	public void OnClick(){
		SceneManager.LoadScene ("MainSelection");
	}

	void firework(){
		Instantiate (fireworks, eP.transform.position, transform.rotation);
	}
}
