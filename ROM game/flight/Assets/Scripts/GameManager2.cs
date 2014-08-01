using UnityEngine;
using System.Collections;

public class GameManager2 : MonoBehaviour {
	// The score that the player currently has
	public int curScore; 
	// The highest score the player has reached (saved)
	private int highscore;
	// Reference to our custom gui skin
	public GUISkin skin;
	// Values defining the width and height of our game over screen
	public Vector2 losePromptWH;
	// Boolean to check if we need to end the game or not
	[HideInInspector]
	public bool showGameOver;
	// Use this for initialization
	void Start () {
		// Grab the last saved highscore from the player prefs file
		highscore = PlayerPrefs.GetInt("Highscore");
	
	}
	
	// Update is called once per frame
	void Update () {
		// If the bird died and our current score is greater than our saved highscore
		if (showGameOver && curScore > highscore)
		{
			// Set the highscore to our current score
			highscore = curScore;
			// Now save the score as our new highscore
			PlayerPrefs.SetInt("Highscore", highscore);
		}
	}

	void OnGUI()
	{
		// Set the GUI's skin to our custom skin
		GUI.skin = skin;
		// Show our current score value at the top center of the screen 
		// (note: it uses the custom Score style in our skin)
		GUI.Label (new Rect (Screen.width / 2 - 100, 10f, 200, 200), 
           curScore.ToString (), skin.GetStyle ("Score"));
		

		}
}
