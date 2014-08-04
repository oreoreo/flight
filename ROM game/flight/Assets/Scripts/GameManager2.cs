using UnityEngine;
using System.Collections;

public class GameManager2 : MonoBehaviour {
	// The score that the player currently has
	public int curScore; 

	public int hearts = 5;
	// The highest score the player has reached (saved)
	private int highscore;
	// Reference to our custom gui skin
	public GUISkin skin;
	// Values defining the width and height of our game over screen
	public Vector2 losePromptWH;
	// Boolean to check if we need to end the game or not
	[HideInInspector]
	public bool showGameOver = false;
	// Use this for initialization
	void Start () {
		// Grab the last saved highscore from the player prefs file
		highscore = PlayerPrefs.GetInt("Highscore");
	
	}
	
	// Update is called once per frame
	void Update () {
		// If the bird died and our current score is greater than our saved highscore

	}

	void OnGUI()
	{
		// Set the GUI's skin to our custom skin
		GUI.skin = skin;
		// Show our current score value at the top center of the screen 
		// (note: it uses the custom Score style in our skin)
		GUI.Label (new Rect (Screen.width / 2 - 300, 10f, 200, 200), 
							"Score: " + curScore.ToString (), skin.GetStyle ("Score"));
		GUI.Label (new Rect (Screen.width / 2 - 300, 10f + 45f, 200, 200), 
		           "Lives: " + hearts.ToString (), skin.GetStyle ("Score"));

		if (GUI.Button (new Rect (Screen.width / 2 + 400, 10f, 200, 200), "Quit", 
			             skin.GetStyle ("Quit"))) {
			Application.LoadLevel ("gameOver");

		}

		if (showGameOver) {
			Application.LoadLevel ("gameOver");
				}
		}
}
