using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TitleBackScript : MonoBehaviour {
	public void OnClickBackFunction() {
		SceneManager.LoadScene("Start");
	} 
}
