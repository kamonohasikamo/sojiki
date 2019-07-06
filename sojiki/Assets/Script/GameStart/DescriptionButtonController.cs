using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DescriptionButtonController : MonoBehaviour {
	public void OnClickFunction() {
		SceneManager.LoadScene("Description");
	} 
}
