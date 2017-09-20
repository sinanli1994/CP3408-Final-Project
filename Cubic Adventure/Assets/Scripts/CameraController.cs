using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public Transform target;	//target for camera to follow
	public float smoothing = 5f;

	Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - target.position; //getting offset
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 targetCamPos = target.position + offset; //set the target camera position
		transform.position = Vector3.Lerp (transform.position, targetCamPos, smoothing * Time.deltaTime); //move the camera using Vector3.Lerp
	}
}
