using UnityEngine;
using System.Collections;

public class WaterScript : MonoBehaviour {

	public GameObject water;

	void Start () {
		InvokeRepeating ("Generate", 1, 1);
	}

	void Generate(){
		Instantiate (water, transform.position, transform.rotation);
	}
}

