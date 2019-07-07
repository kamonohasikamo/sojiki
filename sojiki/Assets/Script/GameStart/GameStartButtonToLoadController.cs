using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameStartButtonToLoadController : MonoBehaviour {

	//　非同期動作で使用するAsyncOperation
	private AsyncOperation async;
	//　シーンロード中に表示するUI画面
	[SerializeField]
	private GameObject loadUI;
	//　読み込み率を表示するスライダー
	[SerializeField]
	private Slider slider;
	public void OnClickStartFunction() {
		//　ロード画面UIをアクティブにする
		loadUI.SetActive(true);
 
		//　コルーチンを開始
		StartCoroutine("LoadStart");
	}

	IEnumerator LoadStart() {
		async = SceneManager.LoadSceneAsync("GameScene");

		while(!async.isDone) {
			var progressVal = Mathf.Clamp01(async.progress / 0.9f);
			slider.value = progressVal;
			yield return null;
		}
	}
}
