using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour {

	public GUISkin skin;


	void OnGUI () {

		GUI.skin = skin;
		GUI.Label (new Rect (180, -50, 300, 300), "The Cubic Adventure");

		if (GUI.Button (new Rect (210, 180, 100, 40), "Play")) {
			SceneManager.LoadScene (1);
		}

		if (GUI.Button (new Rect (330, 180, 100, 40), "Quit")) {
			Application.Quit ();
		}
	}

}