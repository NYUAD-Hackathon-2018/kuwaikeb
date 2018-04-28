using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Mover : MonoBehaviour {

	float originalY;
	public float floatStrength = 1;

	// Use this for initialization
	void Start () {
		this.originalY = this.transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {

		transform.position = new Vector3(transform.position.x,
            originalY + ((float)Math.Sin(Time.time * 3) * floatStrength),
            transform.position.z);
		
	}
}
