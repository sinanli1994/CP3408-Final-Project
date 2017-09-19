using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour {
	public int currentScore;
	public int highScore;

	public int currentLevel = 0;
	public int unlockedLevel;

	public GUISkin skin;
	public float startTime;
	public float currentTime;

	void Update() { //happen every single frame
		startTime -= Time.deltaTime;

	}

	public void CompleteLevel() // Handle the loading of next level
	{
		if (currentLevel < 2) {
			currentLevel += 1;
			SceneManager.LoadScene (currentLevel);
		} else {
			print ("You Win");
		}
	}
}
