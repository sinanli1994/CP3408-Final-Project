using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour {
	public float delayTime;

	// Use this for initialization of wall spike
	void Start () 
	{
		StartCoroutine (Go ());
	}
	
	IEnumerator Go() //handle the wall spike to run infinitely
	{
		while(true)
		{
			gameObject.GetComponent<Animation>().Play ();
			yield return new WaitForSeconds (3f);
		}
	}
}
