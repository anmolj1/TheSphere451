using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour {
	// Use this for initialization
	
	public Rigidbody rb;
	public int moveSpeed = 100;

	void Start () {

		
	}


	
	// Update is called once per frame
	void Update () {
		float horizMove = Input.GetAxis("Horizontal");
		float vertiMove =  Input.GetAxis("Vertical");

		if (Input.GetKeyDown(KeyCode.Space)){
			rb.AddForce(new Vector3(0,10,0), ForceMode.Impulse);
		}

		Vector3 move = new Vector3(horizMove * moveSpeed * Time.deltaTime, 0.0f, vertiMove * moveSpeed * Time.deltaTime);
		rb.AddForce(move);

	}
}