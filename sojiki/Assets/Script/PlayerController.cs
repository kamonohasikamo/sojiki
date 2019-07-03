using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public GameObject playerHand;
	public GameObject gameCamera;
	void Start() {
		//playerHand.transform.rotation = Quaternion.Euler(0, 0, 0);
	}

	void Update() {
		Vector3 cameraPosition = Input.mousePosition;
		cameraPosition.z = 10.0f;
		playerHand.transform.position = Camera.main.ScreenToWorldPoint(cameraPosition); 
		//playerHand.transform.rotation = gameCamera.transform.rotation;
	}
}
