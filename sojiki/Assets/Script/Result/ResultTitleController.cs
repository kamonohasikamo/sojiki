using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultTitleController : MonoBehaviour {
	public Text titleText;
	void Start() {
		if (!SojikiSentanController.getIsGameOver()) {
			titleText.text = "Game Clear!";
		} else {
			titleText.text = "Game Over!";
		}
	}
}
