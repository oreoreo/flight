using UnityEngine;
using System.Collections;

public class gameOver : MonoBehaviour {
	public GUISkin skin;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{
		// Set the GUI's skin to our custom skin
		GUI.skin = skin;
		// Show our current score value at the top center of the screen 
		// (note: it uses the custom Score style in our skin)
		
		GUI.Button (new Rect (Screen.width/2 - 100, Screen.height/2 - 100, 10, 10), "Game Over!", 
		            skin.GetStyle ("gameOver"));
		if (GUI.Button (new Rect (Screen.width/2 - 100, Screen.height/2 - 15, 300, 300), "Play Again?", 
			               skin.GetStyle ("gameOver"))) {
			Application.LoadLevel ("starter");
			
		}

	}
}
