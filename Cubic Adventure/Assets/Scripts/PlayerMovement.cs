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
	public GameManager gameManager;

	// Use this for initialization
	void Start () {
		spawn = transform.position; //storing spawn position
		gameManager = gameManager.GetComponent<GameManager> (); //reference to GameManager
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		input = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0,Input.GetAxisRaw ("Vertical")); // input

		if (rd.velocity.magnitude < maxSpeed) { //sliding effect 
			rd.AddRelativeForce (input * moveSpeed);	//Add force to the attached rigidbody component
		}

		if (transform.position.y < -2) { // set up when player falls off the map
			Die ();
		}
	}

	void OnCollisionEnter(Collision other) //when collide with other
	{ 
		if (other.transform.tag == "Enemy") { 
			Die ();
		}
	}

	void OnTriggerEnter(Collider other) //handle something triggered
	{
		if (other.transform.tag == "Enemy")
		{
			Die ();
		}

		if (other.transform.tag == "Goal")
		{
			gameManager.CompleteLevel ();
		}
	}

	void Die() // called when player is died
	{
		Instantiate (deathParticles, transform.position, Quaternion.Euler(270, 0 , 0)); //create an instance at the position of player
		transform.position = spawn;	//return back to the position of spawn point
	}
}
