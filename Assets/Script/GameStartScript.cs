using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameStartScript : MonoBehaviour {
		
    private GameObject Main;

		void Start (){
			Main = GameObject.Find ("Title");
		}

		void Update (){
			for (int i = 0; i < Input.touchCount; i++) {
				Touch touch = Input.GetTouch (i);
			if (touch.phase == TouchPhase.Began){
				SceneManager.LoadScene ("MainSelection");
				}
			}
			if (Input.GetMouseButtonDown (0)) {
				SceneManager.LoadScene("MainSelection");
			}
		}
}		