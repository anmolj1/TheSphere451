using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endLevel : MonoBehaviour {

void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "Player"){
        	print("touching");
        
        SceneManager.LoadScene("MainMenu");

    }

}
}