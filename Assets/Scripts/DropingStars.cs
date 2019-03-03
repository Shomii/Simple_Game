using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropingStars : MonoBehaviour
{

	public GameObject stars1;
	public GameObject planet;
	public Stars stars_1;

	bool isPlanetsStarted = false;

	void Start ()
	{
		StartCoroutine (GetFirstStars ());
	}

	void Update ()
	{
		if (!isPlanetsStarted) {
			StartCoroutine (GetFirstPlantes ());
		}
	}


	public GameObject Stars1 ()
	{

		GameObject stars = Instantiate (stars1);
		stars.transform.SetParent (transform, false);

		return stars;

	}

	public GameObject Planet1 ()
	{
		
		GameObject planets = Instantiate (planet);
		planets.transform.SetParent (transform, false);

		return planets;

	}

	public IEnumerator GetFirstStars ()
	{

		while (true) {

			float PositionX = Random.Range (-450, 450);
			Quaternion q = Quaternion.identity;
			Vector3 location = new Vector3 (PositionX, 550f, 0f);

			GameObject instStars = Stars1 ();

			instStars.transform.localPosition = location;
			instStars.transform.rotation = q;

			yield return new WaitForSeconds (1f);
		}
	}

	public IEnumerator GetFirstPlantes ()
	{
		isPlanetsStarted = true;
		while (true) {

			float PositionXNegative = Random.Range (-576, -350);
			float PositionXPositive = Random.Range (350, 576);

			List<Vector3> positionX = new List<Vector3> ();
			Vector3 negativeVector3 = new Vector3 (PositionXNegative, 650f, 0f);
			Vector3 positiveVector3 = new Vector3 (PositionXPositive, 650f, 0f);
			positionX.Add (negativeVector3);
			positionX.Add (positiveVector3);

			Quaternion q = Quaternion.identity;
			Vector3 location = positionX [Random.Range (0, positionX.Count)];

			GameObject instPlanets = Planet1 ();

			instPlanets.transform.localPosition = location;

			instPlanets.transform.rotation = q;

			yield return new WaitForSeconds (40f);
		}
	}
}
