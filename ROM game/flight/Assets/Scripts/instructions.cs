using UnityEngine;
using System.Collections;

public class instructions : MonoBehaviour {
	public GUISkin skin;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		GUI.skin = skin;

		if (GUI.Button (new Rect (Screen.width/2 + 250, Screen.height/2 + 150, 100, 200), "Back", 
		                skin.GetStyle ("Back"))) {
			Application.LoadLevel (0);
			
		}
		}
}
