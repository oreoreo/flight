using UnityEngine;
using System.Collections;

public class starter : MonoBehaviour {
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
		GUI.Label (new Rect (Screen.width / 2 + 150, Screen.height / 20 - 30, 50, 200), "Birdwatcher", 
		          skin.GetStyle ("Play"));
		if (GUI.Button (new Rect (Screen.width/2 + 150, Screen.height/2, 100, 200), "Play", 
		                skin.GetStyle ("instructions"))) {
			Application.LoadLevel (1);
			
		}

		if (GUI.Button (new Rect (Screen.width/2 + 150, Screen.height /2 - 75 , 100, 300), "Instructions", 
		    skin.GetStyle ("instructions"))) {
			Application.LoadLevel (3);
		}

	}
}
