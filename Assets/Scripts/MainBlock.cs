using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MainBlock : MonoBehaviour, IPointerDownHandler, IPointerUpHandler/*,IDragHandler*/
{
	
	public float score;
	public TextMeshProUGUI scoreText;
	public TextMeshProUGUI scoreIntNumber;
	public TextMeshProUGUI playerText;
	public Text shieldTextInfo;
	public ButtonControllerForGameScene butt;
	public Ads ad;
	public bool isWatching = false;
	public bool finishWatching = false;
	public Collision2D box;
	public DropingBlocks dropingBlocks;
	public int numberOfLives;

	private SpriteRenderer rend;
	private Image main;
	private bool isDaed;
	private Shield shield;
	private GameController gm;
	private float scorePerSecond = 1f;
	private string stringJustForScore = "";
	private float minX = -8f;
	private float maxX = 8f;
	private float minY = -5f;
	private float maxY = 5f;
	private Collider2D boxx;
	private bool isDragging;
	private Vector3 draggingOffset;

	void Start ()
	{
		boxx = GetComponent<Collider2D> ();
		isDragging = false;
		gm = GetComponent<GameController> ();
		shield = GetComponent<Shield> ();
		isDaed = false;
		playerText.text = Translation.content11;
		shieldTextInfo.text = Translation.content12;
		shieldTextInfo.gameObject.SetActive (false);
		rend = GetComponent<SpriteRenderer> ();
		main = GetComponent<Image> ();

	}

	void Update ()
	{
		
		if (isDragging == true) {
			Vector3 position = Camera.main.ScreenToWorldPoint (Input.mousePosition) + draggingOffset;
			transform.position = new Vector3 (Mathf.Clamp (position.x, minX, maxX), Mathf.Clamp (position.y, minY, maxY), 0f);
		}

		Score ();

	}

	public void OnPointerDown (PointerEventData eventData)
	{
		isDragging = true;
		draggingOffset = transform.position - Camera.main.ScreenToWorldPoint (Input.mousePosition);
	}

	public void OnPointerUp (PointerEventData eventData)
	{
		isDragging = false;
	}



	//	public void Score10More ()
	//	{
	//
	//
	//	}

	private void OnCollisionEnter2D (Collision2D box)
	{

		if (box.gameObject.tag == "RewordBlock10") {
			isDaed = false;
			Destroy (box.gameObject);
			score += 10;
		}
		if (box.gameObject.tag == "RewordBlock20") {
			isDaed = false;
			Destroy (box.gameObject);
			score += 20;
		}
		if (box.gameObject.tag == "RewordBlock30") {
			isDaed = false;
			Destroy (box.gameObject);
			score += 30;
		}
		if (box.gameObject.tag == "Shield") {
			isDaed = false;
			Destroy (box.gameObject);
			StartCoroutine (StartShieldAfterSeconds ());
		}

		if (box.gameObject.tag != "RewordBlock10" && box.gameObject.tag != "RewordBlock20" && box.gameObject.tag != "RewordBlock30" && box.gameObject.tag != "Shield") {
			Destroy (box.gameObject);
			Time.timeScale = 0;
			GameObject[] blocks1;
			blocks1 = GameObject.FindGameObjectsWithTag ("DropingBlocks");
			for (int i = 0; i < blocks1.Length; i++) {
				blocks1 [i].SetActive (false);
			}
			if (dropingBlocks.rewordBlock1 != null) {
				dropingBlocks.rewordBlock1.SetActive (false);
			}
			if (dropingBlocks.rewordBlock2 != null) {
				dropingBlocks.rewordBlock2.SetActive (false);
			}
			if (dropingBlocks.rewordBlock3 != null) {
				dropingBlocks.rewordBlock3.SetActive (false);
			}
			if (dropingBlocks.shieldBlock != null) {
				dropingBlocks.shieldBlock.SetActive (false);
			}
			if (gameObject != null) {
				gameObject.SetActive (false);
			}

			gm.RestartWait2 ();
		}

	}

	public void Collision (Collider2D boxx)
	{

		if (finishWatching) {

			gameObject.transform.localPosition = new Vector3 (0f, -250f, 0f);
			Time.timeScale = 1;

			if (gameObject != null) {
				gameObject.SetActive (true);
			}

			gm.podlogaZaInfo.gameObject.SetActive (false);
			gm.continueButton.gameObject.SetActive (false);
			gm.restartButton.gameObject.SetActive (false);
			gm.returnToMainMenu.gameObject.SetActive (false);

		} else {
			Destroy (gameObject);
			Destroy (boxx.gameObject);
			isDaed = true;
			if (isDaed) {
				score = 0f;
			}	        
		}
		       
	}

	public IEnumerator Blinking (float waitTime)
	{

		float endTime = Time.time + waitTime;
		while (Time.time < endTime) {

			Color firstPass = rend.color;
			firstPass.a = 0.3f;
			rend.color = firstPass;
			main.color = rend.color;

			yield return new WaitForSeconds (0.2f);

			firstPass.a = 0.7f;
			rend.color = firstPass;
			main.color = rend.color;

			yield return new WaitForSeconds (0.2f);
		}

		Color finalPass = rend.color;
		finalPass.a = 1f;
		rend.color = finalPass;
		main.color = rend.color;
			
	}

	public IEnumerator ResetInvulnerability ()
	{

		boxx.enabled = false;

		StartCoroutine (Blinking (3.5f));

		yield return new WaitForSeconds (4);

		boxx.enabled = true;

	}

	public void ThreeLives ()
	{

		numberOfLives = numberOfLives + 1;
		ShowAds ();
	}

	public void ShowAds ()
	{

		ad.ShowRewardedAd ();
		isWatching = true;
		if (isWatching) {
			
			finishWatching = true;

		} else {
			isWatching = false;
		}

	}

	public void ContinuePlaying ()
	{

		if (finishWatching) {

			Collision (boxx);

		} else {
			isWatching = false;
		}

	}

	public void Restart (string name)
	{
		SceneManager.LoadScene (name);
		Time.timeScale = 1;
	}

	public void BackToMainMenu (string name)
	{
		SceneManager.LoadScene (name);
		Time.timeScale = 1;
	}

	IEnumerator StartShieldAfterSeconds ()
	{

		gm.StartShield ();
		StartCoroutine (StartShieldTextInfo ());
		yield return new WaitForSeconds (5);
		gm.shield.gameObject.SetActive (false);

	}

	IEnumerator StartShieldTextInfo ()
	{

		shieldTextInfo.gameObject.SetActive (true);
		shieldTextInfo.text = Translation.content12;
		yield return new WaitForSeconds (2);

		shieldTextInfo.gameObject.SetActive (false);

	}

	public void Score ()
	{
		scoreText.text = Translation.content10;
		scoreIntNumber.text = stringJustForScore + Mathf.RoundToInt (score);
		score += scorePerSecond * Time.deltaTime;
        
	}

}

