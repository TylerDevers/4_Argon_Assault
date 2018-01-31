using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelWin : MonoBehaviour {

	public void WinTextAppear() //called from collisionHandler.cs WinSequence()
	{
		var congrats = GameObject.Find("Congrats");
		var text = congrats.GetComponent<Text>(); //needed UnityEngine.UI namespace, text.text now accesses text field.
		text.enabled = true;
	}

    public void PlayAgain()
    {
		print("btn clicked, PlayAgain");
		SceneManager.LoadScene(1);		
    }
	// todo stop using send message , enable disable button script component.
}
