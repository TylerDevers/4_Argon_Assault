using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke("LoadFirstScene", 5);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

		void LoadFirstScene() 
	{
		SceneManager.LoadScene(1);
	}

	public void StartGame()
	{
		SceneManager.LoadScene(2);
	}
}
