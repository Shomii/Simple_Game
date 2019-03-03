using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataController : MonoBehaviour
{

	private PlayerScore scoreFromPlayer;
	public MainBlock mainBlock;
	private GameController gm;
	public int ziz = 11;

	void Start ()
	{
		LoadPlayerScore ();
	}

	void Update ()
	{
		
	}

	public void NewHighScore (int newScore)
	{
		if (newScore > scoreFromPlayer.playerHighestScore) {
			scoreFromPlayer.playerHighestScore = newScore;
			SavePlayerScore ();
		}
	}

	public int GetHighestPlayerScore ()
	{
	
		return scoreFromPlayer.playerHighestScore;
	}

	public string GetPlayerName ()
	{

		return InputFieldText.stringFromField;
	}

	private void LoadPlayerScore ()
	{
		scoreFromPlayer = new PlayerScore ();

		if (PlayerPrefs.HasKey ("name")) {
			scoreFromPlayer.name = PlayerPrefs.GetString ("name");

		}
		if (PlayerPrefs.HasKey ("playerHighestScore")) {
			scoreFromPlayer.playerHighestScore = PlayerPrefs.GetInt ("playerHighestScore");
		}
	}

	private void SavePlayerScore ()
	{

		PlayerPrefs.SetString ("name", scoreFromPlayer.name);
		PlayerPrefs.SetInt ("playerHighestScore", scoreFromPlayer.playerHighestScore);
	}
}
