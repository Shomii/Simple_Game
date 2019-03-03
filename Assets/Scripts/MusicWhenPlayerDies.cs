using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicWhenPlayerDies : MonoBehaviour
{

	public AudioSource musicWhenPlayerDies;
	public MainBlock main;

	private AudioSource musicInPlayMode;


	void Start ()
	{
		musicInPlayMode = main.GetComponent<AudioSource> ();
	}


	void Update ()
	{

	}

	public void ChooseMusic ()
	{

		if (!musicInPlayMode.isPlaying) {
			musicWhenPlayerDies.Play ();
		}
	}
}
