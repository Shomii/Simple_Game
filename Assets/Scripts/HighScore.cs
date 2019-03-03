using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HighScore : MonoBehaviour
{
	public Image highScore;
	public Image mainManu;
	public Button highScoreButton;
	public TextMeshProUGUI name1, name2, name3, name4, name5, name6, name7, name8, name9, name10;
	public TextMeshProUGUI score1, score2, score3, score4, score5, score6, score7, score8, score9, score10;

	void Start ()
	{
		
	}

	void Update ()
	{
		
	}

	private void GetDots ()
	{
	
		if (Leaderboard.GetEntry (0).name == "" || Leaderboard.GetEntry (0).score == 0) {
			name1.text = "-----";
			score1.text = "--";
		} else {
			name1.text = Leaderboard.GetEntry (0).name;
			score1.text = Leaderboard.GetEntry (0).score.ToString ();
		}
	}

	public void GetHighScores ()
	{
		mainManu.gameObject.SetActive (false);
		highScore.gameObject.SetActive (true);

		if (Leaderboard.GetEntry (0).name == "" || Leaderboard.GetEntry (0).score == 0) {
			name1.text = "-----";
			score1.text = "--";
		} else {
			name1.text = Leaderboard.GetEntry (0).name;
			score1.text = Leaderboard.GetEntry (0).score.ToString ();
		}

		if (Leaderboard.GetEntry (1).name == "" || Leaderboard.GetEntry (1).score == 0) {
			name2.text = "-----";
			score2.text = "--";
		} else {
			name2.text = Leaderboard.GetEntry (1).name;
			score2.text = Leaderboard.GetEntry (1).score.ToString ();
		}

		if (Leaderboard.GetEntry (2).name == "" || Leaderboard.GetEntry (2).score == 0) {
			name3.text = "-----";
			score3.text = "--";
		} else {
			name3.text = Leaderboard.GetEntry (2).name;
			score3.text = Leaderboard.GetEntry (2).score.ToString ();
		}

		if (Leaderboard.GetEntry (3).name == "" || Leaderboard.GetEntry (3).score == 0) {
			name4.text = "-----";
			score4.text = "--";
		} else {
			name4.text = Leaderboard.GetEntry (3).name;
			score4.text = Leaderboard.GetEntry (3).score.ToString ();
		}

		if (Leaderboard.GetEntry (4).name == "" || Leaderboard.GetEntry (4).score == 0) {
			name5.text = "-----";
			score5.text = "--";
		} else {
			name5.text = Leaderboard.GetEntry (4).name;
			score5.text = Leaderboard.GetEntry (4).score.ToString ();
		}

		if (Leaderboard.GetEntry (5).name == "" || Leaderboard.GetEntry (5).score == 0) {
			name6.text = "-----";
			score6.text = "--";
		} else {
			name6.text = Leaderboard.GetEntry (5).name;
			score6.text = Leaderboard.GetEntry (5).score.ToString ();
		}

		if (Leaderboard.GetEntry (6).name == "" || Leaderboard.GetEntry (6).score == 0) {
			name7.text = "-----";
			score7.text = "--";
		} else {
			name7.text = Leaderboard.GetEntry (6).name;
			score7.text = Leaderboard.GetEntry (6).score.ToString ();
		}

		if (Leaderboard.GetEntry (7).name == "" || Leaderboard.GetEntry (7).score == 0) {
			name8.text = "-----";
			score8.text = "--";
		} else {
			name8.text = Leaderboard.GetEntry (7).name;
			score8.text = Leaderboard.GetEntry (7).score.ToString ();
		}

		if (Leaderboard.GetEntry (8).name == "" || Leaderboard.GetEntry (8).score == 0) {
			name9.text = "-----";
			score9.text = "--";
		} else {
			name9.text = Leaderboard.GetEntry (8).name;
			score9.text = Leaderboard.GetEntry (8).score.ToString ();
		}

		if (Leaderboard.GetEntry (9).name == "" || Leaderboard.GetEntry (9).score == 0) {
			name10.text = "-----";
			score10.text = "--";
		} else {
			name10.text = Leaderboard.GetEntry (9).name;
			score10.text = Leaderboard.GetEntry (9).score.ToString ();
		}
	}
}
