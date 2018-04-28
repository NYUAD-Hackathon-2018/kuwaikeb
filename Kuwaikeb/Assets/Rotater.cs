using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Rotater : MonoBehaviour {
	float originalX;
	public float deg = 5;

	// Use this for initialization
	void Start () {
		// this.originalX = this.transform.position.x;
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		Rotate(deg);
	}

	public void Rotate(float deg)
	{
		transform.Rotate(0, 0, deg);
	}
}
