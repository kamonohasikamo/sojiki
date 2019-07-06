using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {
	public Text ScoreText;
	public static int Score;

	void Start() {
		Score = 0;
		ScoreText.text = Score.ToString() + "点";
	}

	void Update() {
		ScoreText.text = Score.ToString() + "点";
	}
	public static void setScore(int setScore) {
		Score += setScore;
	}

	public static int getScore() {
		return Score;
	}
}
