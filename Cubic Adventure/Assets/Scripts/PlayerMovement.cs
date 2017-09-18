using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement: MonoBehaviour {

	public float moveSpeed; //speed modifier of the player
	private float maxSpeed = 5f;
	private Vector3 input;
	public Rigidbody rd; 

	private Vector3 spawn;
	public GameObject deathParticles;

	// Use this for initialization
	void Start () {
		spawn = transform.position; //storing spawn position
	}
	
	// Update is called once per frame
	void Update () {

		input = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0,Input.GetAxisRaw ("Vertical")); // input

		if (rd.velocity.magnitude < maxSpeed) { //sliding effect 
			rd.AddForce (input * moveSpeed);	//Add force to the attached rigidbody component
		}
	}

	void OnCollisionEnter(Collision other) { //when collide with other
		if (other.transform.tag == "Enemy") { 
			Instantiate (deathParticles, transform.position, Quaternion.identity); //create an instance at the position of player
			transform.position = spawn;	//return back to the position of spawn point
		}
	}
}
