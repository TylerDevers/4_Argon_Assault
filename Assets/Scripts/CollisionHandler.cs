using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour {

	[Tooltip("in seconds")] [SerializeField] float levelLoadDelay = 1f;
	[Tooltip("FX prefab on player")] [SerializeField] GameObject deathFX;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) 
	{
		StartDeathSequence();
		deathFX.SetActive(true);
		Invoke("ReloadScene", levelLoadDelay);
	}

	 void StartDeathSequence()
    {
		SendMessage("OnPlayerDeath");
    }

	void ReloadScene()
	{
		SceneManager.LoadScene(1);
	}
}
