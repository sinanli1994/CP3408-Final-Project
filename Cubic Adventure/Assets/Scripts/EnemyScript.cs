using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

	public Transform[] patrolPoints;	//stores position points that the enemy has to move
	private int currentPoint;	//current position point of the enemy
	public float moveSpeed;

	// Use this for initialization
	void Start () {
		transform.position = patrolPoints [0].position;
		currentPoint = 0;
	}
	
	// Update is called once per frame
	void Update () {

		if (transform.position == patrolPoints [currentPoint].position) {
			currentPoint++;

			if (currentPoint == patrolPoints.Length) {
				currentPoint = 0;
			}
		}
			

		transform.position = Vector3.MoveTowards (transform.position, patrolPoints [currentPoint].position, moveSpeed * Time.deltaTime);
	}
}
