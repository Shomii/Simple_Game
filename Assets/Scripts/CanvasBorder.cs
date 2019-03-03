using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasBorder : MonoBehaviour
{

	void Start ()
	{

	}

	void Update ()
	{
		
	}

	private void OnCollisionEnter2D (Collision2D other)
	{
		Destroy (other.gameObject);
	}
}
