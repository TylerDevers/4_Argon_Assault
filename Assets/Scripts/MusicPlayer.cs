using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour {

	// Use this for initialization

	void Awake() 
	{
		DontDestroyOnLoad(this);
	}
	void Start () {
		Invoke("LoadFirstScene",5);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void LoadFirstScene() 
	{
		SceneManager.LoadScene(1);
	}
}
