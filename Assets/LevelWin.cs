using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelWin : MonoBehaviour {

	//var congrats = GameObject.Find("Congrats");

	// Use this for initialization
	void Start () {
		//Invoke("WinTextAppear", 5);
		WinTextAppear();
	}
	
	// Update is called once per frame
	void Update () {
		//print("update neing called ");
	}

	void WinTextAppear()
	{
		//serialize Gameobject[] winTextField // attach canvas text to it.
		//then get objects component and enable it, or make it active.
		var congrats = GameObject.FindWithTag("Respawn");
		//var canvas = GetComponent<Canvas>();
		//var showWin =  canvas.transform.Find("Win").gameObject;
		//SetActive(true);
		print(" WinTextAppear ");
	}
}
