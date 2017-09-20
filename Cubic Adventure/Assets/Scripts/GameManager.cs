using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour {
	public int currentScore;
	public int highScore;

	public int currentLevel;
	public int unlockedLevel;

	public GUISkin skin;
	public float startTime;
	public float currentTime;

	void Start()
	{
		DontDestroyOnLoad (gameObject);
	}

	void Update() { //happen every single frame
		startTime -= Time.deltaTime;

	}

	public void CompleteLevel() // Handle the loading of next level
	{
		currentLevel = SceneManager.GetActiveScene ().buildIndex; //get current running scene index

		if (currentLevel < Application.levelCount) {
			currentLevel += 1; //increment to next scene
			SceneManager.LoadScene (currentLevel);
		} else {
			print ("You Win");
		}
	}
}
