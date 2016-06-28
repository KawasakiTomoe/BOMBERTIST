using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BalloonScript : MonoBehaviour {

	float timer = 0.0f;
	public GameObject bomb;
	public Canvas nal;

	// Use this for initialization
	void Start () {
		nal.enabled = false;
	}
	
	// Update is called once per frame
	void Update (){
			timer += Time.deltaTime;
			transform.localScale = new Vector3 (6 + timer, 6 + timer, 6 + timer);
			Invoke ("burst", 3.0f);
	}
		
	void burst() {
		Destroy (this.gameObject);
		Instantiate (bomb, transform.position, transform.rotation);
		nal.enabled = true;
		Debug.Log (2);
		}
}