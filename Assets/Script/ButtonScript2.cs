using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonScript2 : MonoBehaviour {

	public void OnClick (int number){

		switch (number) {
		case 0:
			SceneManager.LoadScene ("NO");
			break;
		case 1:
			SceneManager.LoadScene ("NI");
			break;
		case 2:
			SceneManager.LoadScene ("NAl");
			break;
		case 3:
			SceneManager.LoadScene ("OI");
			break;
		case 4:
			SceneManager.LoadScene ("OAl");
			break;
		case 5:
			SceneManager.LoadScene ("IAl");
			break;
		}
	}
}