using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SojikiSentanController : MonoBehaviour {
	public GameObject sojikiSentan;
	public static bool isGameOver;
	public AudioClip itemGetSound;
	AudioSource audioSource;
	void Start() {
		isGameOver = false;
		// SE Audio Source
		audioSource = GetComponent<AudioSource>();
	}
	void OnCollisionEnter(Collision other) {
		if (Input.GetMouseButton(0)) {
			if (other.gameObject.tag == "Tanni") {
				audioSource.PlayOneShot(itemGetSound);
				Destroy(other.gameObject);
				ScoreController.setScore(100);
			}
			if (other.gameObject.tag == "Tanni_yu") {
				audioSource.PlayOneShot(itemGetSound);
				Destroy(other.gameObject);
				ScoreController.setScore(80);
			}
			if (other.gameObject.tag == "Tanni_ryo") {
				audioSource.PlayOneShot(itemGetSound);
				Destroy(other.gameObject);
				ScoreController.setScore(70);
			}
			if (other.gameObject.tag == "Tanni_ka") {
				audioSource.PlayOneShot(itemGetSound);
				Destroy(other.gameObject);
				ScoreController.setScore(60);
			}
			if (other.gameObject.tag == "Huka") {
				Destroy(other.gameObject);
				isGameOver = true;
				SceneManager.LoadScene("Result");
			}
		}
	}

	public static bool getIsGameOver() {
		return isGameOver;
	}
}
