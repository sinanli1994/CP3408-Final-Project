using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour {
	public static int currentScore;
	public static int highScore;

	public static int currentLevel = 0;
	public static int unlockedLevel;

	public static void CompleteLevel() // Handle the loading of next level
	{
		if (currentLevel < 2) {
			currentLevel += 1;
			SceneManager.LoadScene (currentLevel);
		} else {
			print ("You Win");
		}
	}
}
