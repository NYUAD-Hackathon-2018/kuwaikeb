using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubButtonScript : MonoBehaviour {

	Button btn;

	// Use this for initialization
	void Start () {
		btn = gameObject.GetComponent<Button> ();
		btn.onClick.AddListener(taskOnClick);
		btn.interactable = false;
	}

	void taskOnClick(){
		int level = GameObject.Find ("GameManager").GetComponent<MathManager> ().maxLevel;
		if (level >= 2) {
			GameObject.Find ("Canvas/Options").SetActive (false);
			GameObject.Find ("GameManager").GetComponent<MathManager> ().generate ("Selective", '-');
		} else {
			// do something
		}

	}

}
