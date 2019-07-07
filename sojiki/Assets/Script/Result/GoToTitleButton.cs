using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoToTitleButton : MonoBehaviour {
	
	public void GotoTitleFunction() {
		SceneManager.LoadScene("Start");
	}

}
