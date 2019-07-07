using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class ShowTextController : MonoBehaviour {
	public GameObject objText;
	public Text UIText;

	public string result;
	void Start() {
		StartCoroutine (textLoad());
	}

	IEnumerator textLoad() {
		string filepath = Application.streamingAssetsPath + "/GameDescription.txt";
		if (filepath.Contains ("://") || filepath.Contains (":///")) {
			WWW www = new WWW (filepath);
			yield return www;
			result = www.text;
			load(result);
		} else {
			result = File.ReadAllText (filepath);
			load(result);
		}
	}

	void load(string resultString) {
		UIText = objText.GetComponent<Text>();
		// string filePath = Application.streamingAssetsPath + "/StreamingAssets/GameDescription.txt";
 
		//　ファイルが存在しなければ作成
		// if (!File.Exists (filePath)) {
		// 	using (File.Create (filePath)) {
		// 	}
		// }
 
		// string allText2 = File.ReadAllText (filePath);
		UIText.text = resultString;
	}

}
