﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class orderScript : MonoBehaviour {

	public Text order;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
		order.enabled = false;
	}

	void OnMouseUp(){
		order.enabled = true;
	}

}
