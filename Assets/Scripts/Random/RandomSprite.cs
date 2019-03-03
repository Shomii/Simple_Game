using UnityEngine;
using System.Collections;

[RequireComponent (typeof(SpriteRenderer))]
public class RandomSprite : MonoBehaviour
{
	
	public Sprite[] sprites;

	private SpriteRenderer spriteRenderer;

	void Start ()
	{
		spriteRenderer = GetComponent<SpriteRenderer> ();
		Generate ();
	}

	public void Generate ()
	{
		if (sprites.Length > 0) {
			spriteRenderer.sprite = sprites [Random.Range (0, sprites.Length)];
		}
	}

	void Update ()
	{
	
	}
}
