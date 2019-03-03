using UnityEngine;
using System.Linq;

using System.Collections.Generic;

public static class Leaderboard
{
	public const int EntryCount = 250;
	public static int max;

	public struct ScoreEntry
	{
		public string name;
		public int score;

		public ScoreEntry (string name, int score)
		{
			this.name = name;
			this.score = score;
		}
	}

	private static List<ScoreEntry> s_Entries;

	private static List<ScoreEntry> Entries {
		get {
			if (s_Entries == null) {
				s_Entries = new List<ScoreEntry> ();
				LoadScores ();
			}
			return s_Entries;
		}
	}

	private const string PlayerPrefsBaseKey = "leaderboard";

	private static void SortScores ()
	{
		s_Entries.Sort ((a, b) => b.score.CompareTo (a.score));
	}

	public static void LoadScores ()
	{
		s_Entries.Clear ();

		for (int i = 0; i < EntryCount; ++i) {
			ScoreEntry entry;
			entry.name = PlayerPrefs.GetString (PlayerPrefsBaseKey + "[" + i + "].name", "");
			entry.score = PlayerPrefs.GetInt (PlayerPrefsBaseKey + "[" + i + "].score", 0);
			s_Entries.Add (entry);
		}

		SortScores ();
	}

	public static void SaveScores ()
	{
		for (int i = 0; i < EntryCount; ++i) {
			var entry = s_Entries [i];
			PlayerPrefs.SetString (PlayerPrefsBaseKey + "[" + i + "].name", entry.name);
			PlayerPrefs.SetInt (PlayerPrefsBaseKey + "[" + i + "].score", entry.score);
		}
	}

	public static ScoreEntry GetEntry (int index)
	{
		return Entries [index];
	}

	public static void Record (string name, int score)
	{
		Entries.Add (new ScoreEntry (name, score));
		SortScores ();
		Entries.RemoveAt (Entries.Count - 1);
		SaveScores ();
	}

	public static int GetMax ()
	{
		List<int> highScoree = new List<int> ();
		for (int i = 0; i < EntryCount; i++) {
			ScoreEntry entry = GetEntry (i);

			if (entry.name == InputFieldText.stringFromField) {

				int scoreess = entry.score;
				highScoree.Add (scoreess);
			}
		}
		if (highScoree.Count == 0) {
			max = 0;
		} else {
			max = highScoree.Max ();
		}
		return max;
	}

}
