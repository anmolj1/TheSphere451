using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour {
	// Use this for initialization
	
	public Rigidbody rb;
	public int moveSpeed = 1;
	void Start () {

		
	}


	
	// Update is called once per frame
	void Update () {
		float horizMove = Input.GetAxis("Horizontal");
		float vertiMove =  Input.GetAxis("Vertical");

		Vector3 move = new Vector3(horizMove * moveSpeed * Time.deltaTime,0.0f, vertiMove * moveSpeed * Time.deltaTime);
		rb.AddForce(move);

	}
}