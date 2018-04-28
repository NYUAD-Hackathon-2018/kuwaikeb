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


	public void goBack ()
	{

		
		Debug.Log("About Us being clicked");
		SceneManager.LoadScene("DoaaScene");
		// Application.LoadLevel("about-us");
	}

	public void goForwards ()
	{
		Debug.Log("About Us being clicked");
		SceneManager.LoadScene("about-us");
	}

}
