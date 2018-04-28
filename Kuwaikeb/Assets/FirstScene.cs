<<<<<<< HEAD
﻿using System.Collections;
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

}
||||||| merged common ancestors
﻿using System.Collections;
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
=======
﻿using System.Collections;
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
>>>>>>> 5ae4d7af64fc0e8dc74cc9893185d4678d491025
