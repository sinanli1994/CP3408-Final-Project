using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EndingScript : MonoBehaviour {

	public GUISkin skin;

	void OnGUI () {
		int Labelwidth = Screen.width/ 2;
		int Labelheight = Screen.height/ 2;

		int Buttonwidth = Screen.width / 2;
		int Buttonheight = Screen.height / 2;

		GUI.skin = skin;
		GUI.Label (new Rect (Labelwidth - 400, Labelheight - 400, 800, 800), "The End");

		if (GUI.Button (new Rect (Buttonwidth - 50, Buttonheight + 30, 100, 40), "Quit")) {
			Application.Quit ();
		}
	}

}