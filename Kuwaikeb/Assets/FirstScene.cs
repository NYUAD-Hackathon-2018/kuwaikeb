using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstScene : MonoBehaviour {

	// void Start ()
	// {
	// 	Debug.Log("Working");
	// 	SceneManager.LoadScene("about-us");
	// }


	public void goToScene (string sceneName)
	{

		Debug.Log("About Us being clicked");
		SceneManager.LoadScene(sceneName);
		// Application.LoadLevel("about-us");
	}

}
