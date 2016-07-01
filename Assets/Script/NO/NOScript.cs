using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NOScript : MonoBehaviour {

	public GameObject macchi;
	public GameObject fire;
	public GameObject react;

	public Animator order;

	public Text order1;

	public Animator element2;
	public Animator button;

	float flag = 0;

	// Use this for initialization
	void Start () {
		element2 = GetComponent<Animator> ();
		react.SetActive (false);
		Invoke ("NextAnimation", 3.0f);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision other){
		if (other.gameObject.name == "macchi") {
			flag = 1;
			StartAnimation ();
		}
	}

	void StartAnimation(){
		if (flag == 1) {
			react.SetActive (true); 
			element2.SetTrigger ("switch3");
			Destroy (macchi.gameObject);
			Invoke("end", 1.5f);
			Invoke ("Anime", 2.0f);
		}
	}

	void OnMouseDown() {
		order1.enabled = false;
	}

	void OnMouseUp(){
		order1.enabled = true;
	}

	void end(){
		Destroy (fire.gameObject);
	}

	void NextAnimation(){
		order.SetTrigger ("switch");
	}

	void Anime(){
		button.SetTrigger ("switch");
	}

	public void OnClick(){
		SceneManager.LoadScene ("MainSelection");
	}
}
