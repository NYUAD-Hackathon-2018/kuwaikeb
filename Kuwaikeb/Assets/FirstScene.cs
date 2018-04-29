
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class FirstScene : MonoBehaviour {

	public GameObject QA;
	public GameObject Options;
	public GameObject correctAnswer;

	// void Start ()
	// {
	// 	Debug.Log("Working");
	// 	SceneManager.LoadScene("about-us");
	// }


	public void goToScene (string sceneName)
	{

		Debug.Log("Button being clicked");
		SceneManager.LoadScene(sceneName);
		// Application.LoadLevel("about-us");
	}

	public void goToScene (int sceneNumber)
	{

		Debug.Log("Button being clicked");
		SceneManager.LoadScene(sceneNumber);
		// Application.LoadLevel("about-us");
	}

	public void LoadScene(int level)
      { 
         Application.LoadLevel(level);
       }

    public void onMouseDown()
    {
    	Options.SetActive (true);
		QA.SetActive (false);
		correctAnswer.SetActive (false);
    }

    public void goToOptions()
    {
    	Options.SetActive (true);
		QA.SetActive (false);
		correctAnswer.SetActive (false);
    }

}

