using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour {

	public GUISkin skin;


	void OnGUI () {
		int Labelwidth = Screen.width/ 2;
		int Labelheight = Screen.height/ 2;

		int Buttonwidth = Screen.width / 2;
		int Buttonheight = Screen.height / 2;

		GUI.skin = skin;
		GUI.Label (new Rect (Labelwidth - 400, Labelheight - 500, 800, 800), "The Cubic Adventure");

		if (GUI.Button (new Rect (Buttonwidth - 110, Buttonheight + 100, 100, 40), "Play")) {
			SceneManager.LoadScene (1);
		}

		if (GUI.Button (new Rect (Buttonwidth + 10, Buttonheight + 100, 100, 40), "Quit")) {
			Application.Quit ();
		}
	}

}