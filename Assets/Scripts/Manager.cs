using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {
	
	public float screenW = Screen.width;
	public float screenH = Screen.height;

	// Use this for initialization
	void Start () {
	}


	// Update is called once per frame
	void Update () {
		if (Application.platform == RuntimePlatform.Android && Input.GetKey(KeyCode.Escape)) {
			Application.Quit ();
		}
	}
	void OnGUI(){
			//StartButton
			if (GUI.Button (new Rect (screenW / 2, screenH / 4, 125, 75), "Start")) {
					Application.LoadLevel(1);
			}

			//QuitButton
			if (GUI.Button (new Rect (screenW / 2, screenH / 4 + 100, 125, 75), "Quit")) {
					Application.Quit ();
			}
	}
}