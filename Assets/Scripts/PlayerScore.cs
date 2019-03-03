using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class PlayerScore
{

	public string name = InputFieldText.stringFromField;
	public List<string> playerNames = new List<string> ();
	public int playerScore = 0;
	public int playerHighestScore = 0;

	void Start ()
	{
		
	}

	void Update ()
	{

	}

}
