using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour {

	// Use this for initialization
	public Rigidbody rb;
	
	void OnTriggerStay(Collider c)
    {	
        if (c.transform.name == "Player"){
       		rb.AddForce(new Vector3(0,10,0), ForceMode.Impulse);


    }


		
	}
}
