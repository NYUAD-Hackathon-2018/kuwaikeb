using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuickButtonScript : MonoBehaviour {

	Button btn;

	// Use this for initialization
	void Start () {
		btn = gameObject.GetComponent<Button> ();
		btn.onClick.AddListener(taskOnClick);
	}

	void taskOnClick(){
		GameObject.Find ("Canvas").SetActive (false);
		GameObject.Find ("MathManager").GetComponent<MathManager> ().generate ("Rush", '+');
	}

}
