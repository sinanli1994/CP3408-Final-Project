using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour {
	public int currentLevel;
	public GUISkin skin;

	void Start()
	{
		DontDestroyOnLoad (gameObject);
	}

	public void CompleteLevel() // Handle the loading of next level
	{
		currentLevel = SceneManager.GetActiveScene ().buildIndex; //get current running scene index

		if (currentLevel >= 0) {
			currentLevel += 1; //increment to next scene
			if (currentLevel < 5) {
				SceneManager.LoadScene (currentLevel);
			}
		} 
	}
}
