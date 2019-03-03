using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms;
using TMPro;

public class GameController : MonoBehaviour
{

	private DataController data;
	public MainBlock scoreMain;
	public Image podlogaZaInfo;
	public Ads ad;
	public TextMeshProUGUI scoreTextInfo;
	public TextMeshProUGUI bestScoreText;
	public TextMeshProUGUI playerUserName;
	public TextMeshProUGUI restartText;
	public TextMeshProUGUI bestScoreInfo;
	public TextMeshProUGUI mainMenuText;
	public Image displaysScoreMessage;
	public Image shield;
	public TextMeshProUGUI scoreInMessage;
	public Button restartButton;
	public Button continueButton;
	public TextMeshProUGUI continueButtonText;
	public Button returnToMainMenu;

	private float scoreFromMainBlock;
	private PlayerScore scoreFromPlayer;
	private string playerName;
	private int playerScore;


	void Start ()
	{
		data = GetComponent<DataController> ();
		restartButton.gameObject.SetActive (false);
		returnToMainMenu.gameObject.SetActive (false);
		continueButton.gameObject.SetActive (false);
		displaysScoreMessage.gameObject.SetActive (false);
		shield.gameObject.SetActive (false);
		playerName = data.GetPlayerName ();
		PlayerName ();
		scoreTextInfo.text = Translation.content15;
		restartText.text = Translation.content13;
		bestScoreInfo.text = Translation.content16;
		mainMenuText.text = Translation.content14;
		continueButtonText.text = Translation.content17;
	}

	void Update ()
	{
		scoreFromMainBlock = scoreMain.score;
	}

	public void PlayerName ()
	{
		playerUserName.text = playerName;
	}

	public void StartShield ()
	{
		shield.gameObject.SetActive (true);
	}

	public void RestartWait2 ()
	{

		restartButton.gameObject.SetActive (true);

		restartText.text = Translation.content13;
		displaysScoreMessage.gameObject.SetActive (true);
		returnToMainMenu.gameObject.SetActive (true);

		if (scoreMain.numberOfLives >= 3) {
			continueButton.gameObject.SetActive (false);
		} else {
			continueButton.gameObject.SetActive (true);
		}

		float m = Mathf.RoundToInt (scoreFromMainBlock);

		scoreInMessage.text = m.ToString ();

		scoreFromPlayer = new PlayerScore ();

		data.NewHighScore ((int)scoreFromMainBlock);

		Leaderboard.Record (scoreFromPlayer.name, (int)m);

		playerScore = Leaderboard.GetMax ();
		bestScoreText.text = playerScore.ToString ();
	}
		
}
