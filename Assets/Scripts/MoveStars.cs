using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStars : MonoBehaviour
{

	public float speedMax;
	public float speedMin;
	private Rigidbody2D rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody2D> ();
		MoveAllBlocks ();
	}

	void Update ()
	{

	}

	public void MoveAllBlocks ()
	{

		rb.velocity = new Vector2 (0f, -1) * Random.Range (speedMax, speedMin);
	}
	
}
