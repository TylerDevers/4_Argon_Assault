﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour {

	// Use this for initialization

	void Awake() 
	{
		int numMusicPlayers = FindObjectsOfType<MusicPlayer>().Length;
		if (numMusicPlayers > 1) 
		{
			Destroy(gameObject);
		} 
		else
		{
			DontDestroyOnLoad(this);
		}
	}
}
