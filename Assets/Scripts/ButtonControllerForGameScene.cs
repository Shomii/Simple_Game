using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonControllerForGameScene : MonoBehaviour
{

	public Translation trans;
	public MainBlock main;
	public GameController gm;

	private string userName;

	public void Start ()
	{

	}

	public void Update ()
	{

	}

	public void Serbian ()
	{
		Language.code = "rs";
		trans.ReadTranslation ();
		main.scoreText.text = Translation.content10;
		main.playerText.text = Translation.content11;
		main.shieldTextInfo.text = Translation.content12;
		gm.restartText.text = Translation.content13;
		gm.mainMenuText.text = Translation.content14;
		gm.scoreTextInfo.text = Translation.content15;
		gm.bestScoreInfo.text = Translation.content16;
	}

	public void English2 ()
	{
		Language.code = "en";
		trans.ReadTranslation ();
		main.scoreText.text = Translation.content10;
		main.playerText.text = Translation.content11;
		main.shieldTextInfo.text = Translation.content12;
		gm.restartText.text = Translation.content13;
		gm.mainMenuText.text = Translation.content14;
		gm.scoreTextInfo.text = Translation.content15;
		gm.bestScoreInfo.text = Translation.content16;
	}
}
