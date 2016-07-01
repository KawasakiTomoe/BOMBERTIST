using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

  public class OAlScript : MonoBehaviour {

	public GameObject Al;
	public GameObject bomb;
	public GameObject Senkou; 

	public Animator order;
	public Animator bottun;

	// Use this for initialization
	void Start () {
		Invoke ("NextAnimation", 3.0f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.name == "fire") {
			Instantiate (bomb, transform.position, transform.rotation);
			Destroy (Senkou.gameObject);
			Destroy (this.gameObject);
			bottun.SetTrigger ("switch");
		}
	}

	void NextAnimation(){
		order.SetTrigger ("switch");
	}
		
	public void OnClick(){
		SceneManager.LoadScene ("MainSelection");
	}
}
