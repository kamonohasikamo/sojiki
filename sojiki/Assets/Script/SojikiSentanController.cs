﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SojikiSentanController : MonoBehaviour {
	public GameObject sojikiSentan;
	public static bool isGameOver;
	void Start() {
		isGameOver = false;
	}
	void OnCollisionEnter(Collision other) {
		Debug.Log("Hit!");
		if (other.gameObject.tag == "Tanni") {
			Destroy(other.gameObject);
			ScoreController.setScore(100);
		}
		if (other.gameObject.tag == "Tanni_yu") {
			Destroy(other.gameObject);
			ScoreController.setScore(80);
		}
		if (other.gameObject.tag == "Tanni_ryo") {
			Destroy(other.gameObject);
			ScoreController.setScore(70);
		}
		if (other.gameObject.tag == "Tanni_ka") {
			Destroy(other.gameObject);
			ScoreController.setScore(60);
		}
		if (other.gameObject.tag == "Huka") {
			Destroy(other.gameObject);
			isGameOver = true;
		}
	}

	public static bool getIsGameOver() {
		return isGameOver;
	}
}
