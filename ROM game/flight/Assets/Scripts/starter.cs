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
	
		if (GUI.Button (new Rect (200, (Screen.height * 2)/3, 200, 200), "Play", 
		                skin.GetStyle ("Play"))) {
			Application.LoadLevel ("tester");
			
		}
	}
}
