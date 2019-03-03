using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InputFieldText : MonoBehaviour
{

	public GameObject canvas;
	public Image highScore;
	public TextMeshProUGUI enterGameText;
	public TextMeshProUGUI highscoreText;
	public TextMeshProUGUI placeholderText;
	public TextMeshProUGUI resetHighscoreText;
	public TextMeshProUGUI quitText;
	public TextMeshProUGUI highscoreTableText;
	public TextMeshProUGUI namehighscoresText;
	public TextMeshProUGUI scoreHighscoreText;
	public TextMeshProUGUI backToMainMenuText;
	public static string stringFromField;

	private TextMeshProUGUI textFromInputField;


	void Start ()
	{
		highScore.gameObject.SetActive (false);
		enterGameText.text = Translation.content;
		highscoreText.text = Translation.content2;
		placeholderText.text = Translation.content3;
		resetHighscoreText.text = Translation.content4;
		quitText.text = Translation.content5;
		highscoreTableText.text = Translation.content6;
		namehighscoresText.text = Translation.content7;
		scoreHighscoreText.text = Translation.content8;
		backToMainMenuText.text = Translation.content9;
	}

	void Update ()
	{

	}

	public void GetUserName ()
	{
		textFromInputField = canvas.transform.Find ("Main menu/TextMeshPro - InputField/Text Area/Text").GetComponent<TextMeshProUGUI> ();

		stringFromField = textFromInputField.text;
	}
}
