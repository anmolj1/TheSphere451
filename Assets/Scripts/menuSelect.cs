using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuSelect : MonoBehaviour {

	// Use this for initialization
	public void ChangeScene (string sceneName) {
		SceneManager.LoadScene(sceneName);
		
	}
	
	// Update is called once per frame
	public void quit () {
		Application.Quit();
		
	}
}
