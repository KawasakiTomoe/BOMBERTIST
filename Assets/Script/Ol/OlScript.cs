using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OlScript : MonoBehaviour {

		public GameObject Al;
	    public GameObject babble; 
		public GameObject water;
		public GameObject pipetto;
	    public GameObject ep;

		public screenScript ss;

		public Animator order;
		public Animator btn;

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
			Instantiate (babble, ep.transform.position, ep.transform.rotation);
			Destroy (pipetto.gameObject);
			Invoke ("Btn", 3.0f);
			Debug.Log(2);
			}
		}

		void Btn(){
		btn.SetTrigger ("switch");
	}

	public void OnClick(){
		SceneManager.LoadScene ("MainSelection");
	}		
}
