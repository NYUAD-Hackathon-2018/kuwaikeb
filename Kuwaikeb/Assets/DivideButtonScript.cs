using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DivideButtonScript : MonoBehaviour {

	Button btn;

	// Use this for initialization
	void Start () {
		btn = gameObject.GetComponent<Button> ();
		btn.onClick.AddListener(taskOnClick);
	}

	void taskOnClick(){
		int level = GameObject.Find ("GameManager").GetComponent<MathManager> ().maxLevel;
		if (level >= 4) {
			GameObject.Find ("Canvas/Options").SetActive (false);
			GameObject.Find ("GameManager").GetComponent<MathManager> ().generate ("Selective", '$');
		} else {
			// do something
		}
	}

}
