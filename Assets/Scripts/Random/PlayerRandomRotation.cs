using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRandomRotation : MonoBehaviour
{
	
	public float rotationSpeedMax = 35f;
	public bool randomize = true;
	public Transform child;
	public Transform child2;

	private float rotationSpeed;

	void Start ()
	{
		Generate ();
	}


	public void Generate ()
	{
		if (randomize) {
			rotationSpeed = (Random.Range (0, 100) < 50 ? -1f : 1f) * Random.Range (0f, rotationSpeedMax);
		} else {
			rotationSpeed = rotationSpeedMax;
		}
	}

	void Update ()
	{
		transform.Rotate (0f, 0f, rotationSpeed * Time.deltaTime);
		child.transform.rotation = Quaternion.Euler (0.0f, 0.0f, gameObject.transform.rotation.z * -1.0f);
		child2.transform.rotation = Quaternion.Euler (0.0f, 0.0f, gameObject.transform.rotation.z * -1.0f);
	}
}
