using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
	
	void Start ()
	{
		
	}

	void Update ()
	{
		
	}

	private void OnCollisionEnter2D (Collision2D box)
	{
		if (box.gameObject.tag == "DropingBlocks") {
			Destroy (box.gameObject);

		}
	}
}
