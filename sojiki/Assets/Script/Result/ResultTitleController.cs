using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultTitleController : MonoBehaviour {
	public Text titleText;
	public AudioClip GameOverSound;
	public AudioClip GameClearSound;
	AudioSource audioSource;
	void Start() {
		// SE Audio Source
		audioSource = GetComponent<AudioSource>();
		if (!SojikiSentanController.getIsGameOver()) {
			audioSource.PlayOneShot(GameClearSound);
			titleText.text = "Game Clear!";
		} else {
			audioSource.PlayOneShot(GameOverSound);
			titleText.text = "Game Over!";
		}
	}
}
