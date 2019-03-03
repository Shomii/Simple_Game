using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlocks : MonoBehaviour
{

	public float speed;

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
		rb.velocity = new Vector2 (0f, -1) * speed;
	}
	
}
