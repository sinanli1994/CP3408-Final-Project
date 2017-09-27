using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRush : MonoBehaviour {

	public Transform[] rushPoints;	//stores position points that the enemy has to move
	private int currentPoint;	//current position point of the enemy

	public GameObject enemy;
	private bool checker;

	// Use this for initialization
	void Start () {
		currentPoint = 0;
		checker = false;
	}
		
	void OnTriggerEnter(Collider other) {

		if (other.transform.tag == "Player") {
			checker = true;
		}
	}

	void Update() {
		if (checker == true) {
			enemy.transform.position = Vector4.MoveTowards (transform.position, rushPoints [currentPoint].position, 0);
		}
		checker = false;
	}
}
