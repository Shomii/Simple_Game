using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{

	public Language lang;
	public Translation trans;
	public InputFieldText text;
	public Image highScore;
	public Image mainMenu;

	private string userName;

	public void Start ()
	{

	}

	public void Update ()
	{
		
	}

	public void Restart (string name)
	{
		SceneManager.LoadScene (name);
	}

	public void BackToMainMenu (string name)
	{
		highScore.gameObject.SetActive (false);
		mainMenu.gameObject.SetActive (true);
	}

	public void StartGame (string name)
	{

		userName = InputFieldText.stringFromField;
		if (userName != "" && userName != null) {
			SceneManager.LoadScene (name);
		}
	}

	public void ResetHighScore ()
	{
	
		PlayerPrefs.DeleteAll ();
	}

	public void QuitGame ()
	{

		Application.Quit ();
	}


	public void Serbian2 ()
	{
		Language.code = "rs";
		trans.ReadTranslation ();
		text.enterGameText.text = Translation.content;
		text.highscoreText.text = Translation.content2;
		text.placeholderText.text = Translation.content3;
		text.resetHighscoreText.text = Translation.content4;
		text.quitText.text = Translation.content5;
		text.highscoreTableText.text = Translation.content6;
		text.namehighscoresText.text = Translation.content7;
		text.scoreHighscoreText.text = Translation.content8;
		text.backToMainMenuText.text = Translation.content9;
	}

	public void English ()
	{
		Language.code = "en";
		trans.ReadTranslation ();
		text.enterGameText.text = Translation.content;
		text.highscoreText.text = Translation.content2;
		text.placeholderText.text = Translation.content3;
		text.resetHighscoreText.text = Translation.content4;
		text.quitText.text = Translation.content5;
		text.highscoreTableText.text = Translation.content6;
		text.namehighscoresText.text = Translation.content7;
		text.scoreHighscoreText.text = Translation.content8;
		text.backToMainMenuText.text = Translation.content9;
	}
}
