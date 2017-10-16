using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour {

	private int score;
	public static ScoreTracker Instance;
	public Text ScoreText;
	public Text HighScoreText;

	public int Score{
		get
		{
			return score;

		}
		set
		{
			score = value;
			ScoreText.text = score.ToString();

			if (PlayerPrefs.GetInt ("HighScore") < score) {
				PlayerPrefs.SetInt ("HighScore",score);
				HighScoreText.text = score.ToString();
			}
		}
	}

	void Awake(){
		Instance = this;
		//Remove comment if you want to reset high score.
		//PlayerPrefs.DeleteAll ();

		if (!PlayerPrefs.HasKey ("HighScore"))
			PlayerPrefs.SetInt ("HighScore", 0);

		ScoreText.text = "0"; 
		HighScoreText.text = PlayerPrefs.GetInt ("HighScore").ToString();
	}


}
