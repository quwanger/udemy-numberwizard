using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
	int max, min, guess;
	// Use this for initialization
	void Start () {
		StartGame();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
      //print("[Up] arrow pressed");
			min = guess;
			NextGuess();
    }
		else if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			//print("[Down] arrow pressed");
			max = guess;
			NextGuess();
		}
		else if (Input.GetKeyDown(KeyCode.Return))
		{
			print("I won!");
			StartGame();
		}
	}

	void StartGame()
	{
		max = 1000;
		min = 1;
		guess = 500;

		print("======================================");
		print("Welcome to Number Wizard");
		print("Pick a number in your head, but don't tell me!");

		print("The highest number you can pick is " + max);
		print("The lowest number you can pick is " + min);

		print("Is the number higher or lower than " + guess + "?");
		print("Press [Up] arrow for higher, [Down] for lower, [Return] for equals");

		max = max + 1;
	}

	void NextGuess()
	{
		// Binary chop search. Start with a range of 1-1000. First response if 500 so that's the new min. Meaning now it's a range of 500-1000 and so on...
		guess = (max + min) / 2;
		print("Is the number higher or lower than " + guess + "?");
		print("Press [Up] arrow for higher, [Down] for lower, [Return] for equals");
	}
}
