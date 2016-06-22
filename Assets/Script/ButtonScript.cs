using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour {

	public void OnClick (int number){

		switch (number) {
		case 0:
			SceneManager.LoadScene ("Selection1");
			break;
		case 1:
			SceneManager.LoadScene ("Selection2");
			break;
		case 2:
			SceneManager.LoadScene ("Selection3");
			break;
		case 3:
			SceneManager.LoadScene ("Selection4");
			break;
		case 4:
			SceneManager.LoadScene ("NO");
			break;
		case 5:
			SceneManager.LoadScene ("NI");
			break;
		case 6:
			SceneManager.LoadScene ("NAl");
			break;
		case 7:
			SceneManager.LoadScene ("OI");
			break;
		case 8:
			SceneManager.LoadScene ("OAl");
			break;
		case 9:
			SceneManager.LoadScene ("IAl");
			break;
		}
	}
}