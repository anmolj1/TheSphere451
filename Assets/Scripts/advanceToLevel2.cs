using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class advanceToLevel2 : MonoBehaviour {

	void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "Player"){
        
        SceneManager.LoadScene("Level2");

    }
	}
}
