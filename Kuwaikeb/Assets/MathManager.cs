using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathManager : MonoBehaviour {

	public static string mainMode;
	public static char mainOp;
	public static int mainTried;

	int[] boundaries = new int[10]{0,9,10,19,20,49,50,99,100,999};
	char[] opLevel = new char[4]{'+','-','*','/'};

	int levelMark, totalLevel;

	// Use this for initialization
	void Start () {
			
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void generate(string mode, char op){
		int tried = 0;
		if(mode == "Selective") {
			levelMark = 1;
			totalLevel = 7;
			tried = 5;

		} else {
			levelMark = 3;
			totalLevel = 15;

		}
	}

}
