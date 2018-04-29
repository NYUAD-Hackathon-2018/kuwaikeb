using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class avatarRotater : MonoBehaviour {
	float originalX;
	public float deg = 0.5f;
	float originalZ;

	// Use this for initialization
	void Start () {
		this.originalZ = this.transform.position.z;
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		Rotate(deg);
	}

	public void Rotate(float deg)
	{

		while(originalZ < 20f && originalZ > -20f)
		{
			transform.Rotate(0, 0, -deg);
		}
		
			transform.Rotate(0, 0, deg);
	}
}
