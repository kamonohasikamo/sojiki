using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public GameObject playerHand;
	public GameObject gameCamera;
	public GameObject playerHandAndSojiki;
	public Quaternion playerHandAndSojikiQuaternion;
	void Start() {
	}

	void Update() {
		Vector3 cameraPosition = Input.mousePosition;
		cameraPosition.z = 10.0f;
		playerHand.transform.position = Camera.main.ScreenToWorldPoint(cameraPosition);


		var angle = gameCamera.transform.rotation.eulerAngles.y + 90.0f;
		angle = angle > 180f ? angle - 360f : angle;
		playerHand.transform.rotation
			= Quaternion.Euler(0f, angle, 0f);
	}
}
