using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRush : MonoBehaviour {

	public Transform[] rushPoints;	//stores position points that the enemy has to move
	private int currentPoint;	//current position point of the enemy
	private float moveSpeed;

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
			currentPoint += 1;
			moveSpeed = 6;

			if (currentPoint < rushPoints.Length) {
				currentPoint = 0;
				moveSpeed = 2;
			}

			enemy.transform.position = Vector3.MoveTowards (transform.position, rushPoints[currentPoint].position, moveSpeed * Time.deltaTime);
		}
	}

}
