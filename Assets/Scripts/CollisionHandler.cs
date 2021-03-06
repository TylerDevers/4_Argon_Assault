﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour {

	[Tooltip("in seconds")] [SerializeField] float levelLoadDelay = 1f;
	[Tooltip("FX prefab on player")] [SerializeField] GameObject deathFX;

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.tag == "Finish")
		{
			print("landing achieved");
			WinSequence();
		} 
		else
		{
			StartDeathSequence();
			deathFX.SetActive(true);
			Invoke("ReloadScene", levelLoadDelay);
		}

	}

	 void StartDeathSequence()
    {
		SendMessage("OnPlayerDeath");
    }

	void ReloadScene()
	{
		SceneManager.LoadScene(1);
	}

	void WinSequence()
	{
		//SendMessage("WinTextAppear", true);
		print("Win Sequence called");
		gameObject.GetComponent<LevelWin>().WinTextAppear();
	}
}
