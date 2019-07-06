using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameStartButtonController : MonoBehaviour {
	public void OnClickStartFunction() {
		SceneManager.LoadScene("GameScene");
	} 
}
