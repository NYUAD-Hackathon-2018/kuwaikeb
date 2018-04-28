using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MathManager : MonoBehaviour {

	public GameObject QA;

	protected string mainMode;
	protected char mainOp;
	protected int mainTried;
	protected int correctResult;
	protected int chosenResult;
	protected int numTries;
	protected int currentMark;

	int[] boundaries = new int[10]{0,9,10,19,20,49,50,99,100,999};
	char[] opLevel = new char[4]{'+','-','*','/'};

	float levelMark;
	int totalLevel;
	Button[] btn = new Button[4];

	// Use this for initialization
	void Start () {

		for (int a = 0; a < 4; a++) {
			btn[a] = GameObject.Find ("Canvas/QuestionAnswer/ButtonHolder/" + (a + 1).ToString ()).GetComponent<Button> ();
			btn[a].onClick.AddListener (taskOnClick);
		}

	}

	// Update is called once per frame
	void Update () {
		
	}

	void taskOnClick(){
		if (mainMode == "Selective") {
			// if the answer is right
			levelMark += currentMark;
			if (levelMark > 7)
				levelMark = 7;
			numTries++;
			if (numTries == 3) {
				// Reward functions 
			} else {
				displayQuestion ();
			}


			//if the answer is wrong
			reInitiate ();

		} else {
			// if the answer is right
			levelMark += currentMark;
			if (levelMark > 15)
				levelMark = 15;
			displayQuestion ();

			// if the answer is wrong

			levelMark -= currentMark;
			if (levelMark < 3)
				levelMark = 3;
			displayQuestion ();

		}
			

	}

	public void reInitiate(){
		generate (mainMode,mainOp);
	}
	public void generate(string mode, char op){
		QA.SetActive (true);
		mainOp = op;
		mainTried = 0;
		mainMode = mode;
		numTries = 0;
		if(mode == "Selective") {
			levelMark = 1f;
			totalLevel = 7;
			mainTried = 5;

		} else {
			levelMark = 3f;
			totalLevel = 15;
		}
		displayQuestion ();
	}

	public int[] createQuestion(){
		Debug.Log (mainMode);
		if (mainMode == "Selective")
		{
			Random rnd = new Random();
			int cm = 0;
			int Lx = 0;
			int Ly = 0;
			char op = mainOp;
			Lx = (int) Random.Range(1f, levelMark);
			cm += Lx;
			Ly = Random.Range(Mathf.Min(Lx, (totalLevel - Lx)), (Mathf.Max(Lx, (totalLevel - Lx))));
			cm += Ly;
			currentMark = (2 * (cm / 3));
			int x = Random.Range(boundaries[(Lx - 1) * 2], (boundaries[((Lx - 1) * 2) + 1]) + 1);
			int y = Random.Range(boundaries[(Ly - 1) * 2], (boundaries[((Ly - 1) * 2) + 1]) + 1);
			if (op == '/')
			{
				int tmp = x;
				x = Mathf.Max(x, y);
				y = Mathf.Min(tmp, y);
				y = y - (y % x);
			}
			int[] answers = new int[4];
			int result = 0;
			if (op == '+')
			{
				result = x + y;
			}
			else if (op == '-')
			{
				result = x - y;
			}
			else if (op == '*')
			{
				result = x * y;
			}
			else if (op == '/')
			{
				y=y == 0 ? 1 : y;
				result = x / y;
			}
			correctResult = result;
			answers[0] = result;
			float margin = 0f;
			while (true)
			{
				answers[1] = (int)Random.Range((1 - margin) * (answers[0]-1), (1 + margin) * (answers[0]+1));
				if (answers[1] != answers[0])
				{
					break;
				}
				else
				{
					margin += 0.1f;
				}
			}
			margin = 0f;
			while (true)
			{
				answers[2] = (int)Random.Range((1 - margin) * (answers[0]-1), (1 + margin) * (answers[0]+1));
				if (answers[2] != answers[1] && answers[2] != answers[0])
				{
					break;
				}
				else
				{
					margin += 0.1f;
				}
			}
			margin = 0f;
			while (true)
			{
				answers[3] = (int)Random.Range((1 - margin) * answers[2], (1 + margin) * answers[1]);
				if (answers[3] != answers[2] && answers[3] != answers[1] && answers[3] != answers[0])
				{
					break;
				}
				else
				{
					margin += 0.1f;
				}
			}
			int[] returnArray = new int[6]{x, y, answers[0], answers[1], answers[2], answers[3]};
			return returnArray;

		}
		else
		{
			int cm = 0;
			int Lx = 0;
			int Ly = 0;
			int Loperation = 0;
			Lx = (int) Random.Range(1f, (levelMark / 3f) + 1f);
			cm += Lx;
			Ly = (int) Random.Range(1f, (levelMark / 3f) + 1f);
			cm += Ly;
			Loperation = (int)Random.Range(Mathf.Max(1f, (levelMark / 5f)), Mathf.Min(Mathf.Abs(cm - levelMark), (levelMark / 3f)));
			cm += Loperation;
			currentMark = (2 * (cm / 15));
			int x = Random.Range(boundaries[(Lx - 1) * 2], (boundaries[((Lx - 1) * 2) + 1]) + 1);
			int y = Random.Range(boundaries[(Ly - 1) * 2], (boundaries[((Ly - 1) * 2) + 1]) + 1);
			if (Loperation > 4)
			{
				Loperation = 4;
			}
			Debug.Log ("Error here bcuz Loperation is" + Loperation);
			char op = opLevel[Loperation - 1];
			mainOp = op;
			if (op == '/')
			{
				int tmp = x;
				x = Mathf.Max(x, y);
				y = Mathf.Min(tmp, y);
				y = y - (y % x);
			}
			int[] answers = new int[4];
			int result = 0;
			if (op == '+')
			{
				result = x + y;
			}
			else if (op == '-')
			{
				result = x - y;
			}
			else if (op == '*')
			{
				result = x * y;
			}
			else if (op == '/')
			{
				y=y == 0 ? 1 : y;
				result = x / y;
			}
			correctResult = result;
			answers[0] = result;
			float margin = 0f;
			while (true)
			{
				answers[1] = (int)Random.Range((1 - margin) * (answers[0]-1), (1 + margin) * (answers[0]+1));
				if (answers[1] != answers[0])
				{
					break;
				}
				else
				{
					margin += 0.1f;
				}
			}
			margin = 0f;
			while (true)
			{
				answers[2] = (int)Random.Range((1 - margin) * (answers[0]-1), (1 + margin) * (answers[0]+1));
				if (answers[2] != answers[1] && answers[2] != answers[0])
				{
					break;
				}
				else
				{
					margin += 0.1f;
				}
			}
			margin = 0f;
			while (true)
			{
				answers[3] = (int)Random.Range((1 - margin) * answers[2], (1 + margin) * answers[1]);
				if (answers[3] != answers[2] && answers[3] != answers[1] && answers[3] != answers[0])
				{
					break;
				}
				else
				{
					margin += 0.1f;
				}
			}
			int[] returnArray = new int[6]{ x, y, answers [0], answers [1], answers [2], answers [3] };
			return returnArray;
		}

	}

	void displayQuestion(){
		int[] created = createQuestion ();
		Debug.Log (mainOp);
		foreach (int i in created) {
			Debug.Log ("val " + i);
		}
		int[] answers = new int[4]{ created [2], created [3], created [4], created [5] };
		reshuffle (answers);
		char oper = mainOp;

		int[] xArr = decompose (created [0]);
		int[] yArr = decompose (created [1], true);

		GameObject.Find ("Canvas/QuestionAnswer/Operation").GetComponent<Image> ().sprite = getSprite (mainOp.ToString());
		for (int a = 0; a < 3; a++) {
			GameObject.Find ("Canvas/QuestionAnswer/X/" + (a+1).ToString()).GetComponent<Image> ().sprite = getSprite (xArr[a].ToString());
			GameObject.Find ("Canvas/QuestionAnswer/Y/" + (a+1).ToString()).GetComponent<Image> ().sprite = getSprite (yArr[a].ToString());
		}

		for (int a = 0; a < 4; a++) {
			GameObject.Find ("Canvas/QuestionAnswer/ButtonHolder/" + (a + 1).ToString () + "/Text").GetComponent<Text> ().text = answers [a].ToString ();
		}

	}

	void reshuffle(int[] texts)
	{
		// Knuth shuffle algorithm :: courtesy of Wikipedia :)
		for (int t = 0; t < texts.Length; t++ )
		{
			int tmp = texts[t];
			int r = Random.Range(t, texts.Length);
			texts[t] = texts[r];
			texts[r] = tmp;
		}
	}

	Sprite getSprite(string str){
		return transform.Find (str).gameObject.GetComponent<SpriteRenderer> ().sprite;
//		return gameObject.Find ("GameManager/" + str).GetComponent<Sprite> ();
	}

	int[] decompose(int i, bool isY = false){
		int avoidCounter = 0;
		int[] finalArray = new int[3];
		finalArray [2] = i % 10;
		if (((int)(i / 10)) != 0) {
			i = i / 10;
			finalArray [1] = i % 10;
		} else {
			avoidCounter++;
			finalArray [1] = 10;

		}
		if (((int)(i / 10)) != 0) {
			i = i / 10;
			finalArray [0] = i % 10;
		} else {
			avoidCounter++;
			finalArray [0] = 10;

		}
		if (isY) {
			for (int a = 0; a<avoidCounter; a++){
				int temp = finalArray [0];
				finalArray [0] = finalArray [1];
				finalArray [1] = finalArray [2];
				finalArray [2] = temp;
			}
		}
		Debug.Log ("final array" + finalArray);
		Debug.Log ("avoid counter" + avoidCounter);
		return finalArray;
	}
}
