using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimerController : MonoBehaviour {

	public Text timerText;
 
	public float totalTime;
	public static int seconds;
	void Start() {
		timerText.text = "残り時間：" + seconds.ToString() + "秒";
	}

	void Update() {
		totalTime -= Time.deltaTime;
		seconds = (int)totalTime;
		if (seconds <= 0) {
			seconds = 0;
		}
		timerText.text = "残り時間：" + seconds.ToString() + "秒";
	}
}
