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
	void Start() {
		UIText = objText.GetComponent<Text>();
		string filePath = Application.dataPath + @"\Resources\GameDescription.txt";
 
		//　ファイルが存在しなければ作成
		if (!File.Exists (filePath)) {
			using (File.Create (filePath)) {
			}
		}
 
		string allText2 = File.ReadAllText (filePath);
		UIText.text = allText2;
	}

}
