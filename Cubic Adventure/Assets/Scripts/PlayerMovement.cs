using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float moveSpeed; //speed modifier of the player
	private Vector3 input;

	public Rigidbody rd; 
	private float maxSpeed = 5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		input = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0,Input.GetAxisRaw ("Vertical")); //get input

		if (rd.velocity.magnitude < maxSpeed) { //sliding effect 
			rd.AddForce (input * moveSpeed);	//Add force to the attached rigidbody component
		}
	}
}
