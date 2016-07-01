using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Failed: MonoBehaviour {

	public Animator failce;
	public GameObject back;

	// Use this for initialization
	void Start () {
		back.SetActive(false);
		Invoke ("Next", 9.0f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Next(){
		back.SetActive(true);
	}

	public void OnClick(){
		SceneManager.LoadScene ("MainSelection");
	}
}

