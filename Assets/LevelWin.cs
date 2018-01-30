using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelWin : MonoBehaviour {

	[SerializeField] GameObject winText;

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
		var congrats = GameObject.Find("Congrats");
		var text = congrats.GetComponent<Text>(); //needed UnityEngine.UI namespace, text.text now accesses text field.
		text.enabled = true;
	}
}
