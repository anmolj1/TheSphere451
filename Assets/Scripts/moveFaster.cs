using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveFaster : MonoBehaviour {
	public Rigidbody rb;
	
	void OnTriggerStay(Collider c)
    {	
        if (c.transform.name == "Player"){
       		rb.AddForce(new Vector3(0,0f,100f),ForceMode.VelocityChange);


    }


		
	}
}
