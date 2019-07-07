using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShowNowScore : MonoBehaviour {
	public Text nowScoreText;

	void Start() {
		nowScoreText.text = "Score : " + ScoreController.getScore().ToString() + "点!";
	}
}
