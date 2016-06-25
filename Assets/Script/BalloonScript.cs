using UnityEngine;
using System.Collections;

public class BalloonScript : MonoBehaviour {

	float timer = 0.0f;
	int flag = 0;
	public GameObject bomb;
	public GameObject fire;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (flag == 1) {
			timer += Time.deltaTime;
			transform.localScale = new Vector3 (6 + timer, 6 + timer, 6 + timer);
			Invoke ("burst", 3.0f);
			Debug.Log (1);
		}
	}

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Fire") {
			flag = 1;
			Debug.Log (2);
		}
	}

	void burst() {
		Destroy (fire.gameObject);
		Destroy (this.gameObject);
		Instantiate (bomb, transform.position, transform.rotation);
		Debug.Log (3);
		}
}