﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSoundSystem : MonoBehaviour {

	[Header("Sounds")]

	[Header("Pico")]
	public AudioSource PicoA;
	public AudioSource PicoB;
	public AudioSource PicoC;

	[Header("Ronroneo")]
	public AudioSource Ronroneo;

	float _rtime;

	void Start()
	{
		_rtime = 10f;
	}

	void Update()
	{
		_rtime -= Time.deltaTime;
		if(_rtime <= 0f)
		{
			Ronronear();
			_rtime = Random.Range(10f, 60f);
		}
	}


	void Picaso()
	{
		var azar = Random.Range(1,3);
		if(azar == 1)
		{
			PicoA.Play();
		}
		if(azar == 2)
		{
			PicoB.Play();
		}
		if(azar == 3)
		{
			PicoC.Play();
		}
		
	}


	void Ronronear()
	{
		Ronroneo.Play();
	}

}
