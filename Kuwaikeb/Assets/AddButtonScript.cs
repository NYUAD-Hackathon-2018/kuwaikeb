using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddButtonScript : MonoBehaviour {

	Button btn;

	// Use this for initialization
	void Start () {
		btn = gameObject.GetComponent<Button> ();
		btn.onClick.AddListener(taskOnClick);
	}

	void taskOnClick(){
		GameObject.Find ("Canvas/Options").SetActive (false);
		GameObject.Find ("GameManager").GetComponent<MathManager> ().generate ("Selective", '+');
	}

}
