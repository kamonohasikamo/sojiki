using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class RankingController : MonoBehaviour {
	public Text showRankingText;
	private int[] sort = new int[6];
	private int temp = 0;
	void Start() {
		showRankingText.text = "";
		saveRanking();
		showRanking();
	}

	void saveRanking() {
		PlayerPrefs.SetInt("5", ScoreController.getScore());
		PlayerPrefs.Save();
	}

	void showRanking() {
		for(int i = 0; i < 6; i++) {
			sort[i] = PlayerPrefs.GetInt("" + i, 0);
		}
		for (int start = 1; start < sort.Length; start++) {
			for (int end = sort.Length - 1; end >= start; end--) {
				if (sort[end - 1] <= sort[end]) {
					temp = sort[end - 1];
					sort[end - 1] = sort[end];
					sort[end] = temp;
				}
			}
		}
		bool showRankingFlag = true;
		for (int i = 0; i < 5; i++) {
			if (showRankingFlag && ScoreController.getScore() == sort[i]) {
				showRankingText.text += "<color=red>" + (i + 1) + "位： Score  " + sort[i].ToString() + "点</color>\n";
				PlayerPrefs.SetInt("" + i, sort[i]);
				showRankingFlag = false;
			} else {
				showRankingText.text += i + 1 + "位： Score  " + sort[i].ToString() + "点\n";
				PlayerPrefs.SetInt("" + i, sort[i]);
			}
		}
		PlayerPrefs.Save();
	}
}
