using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public GameObject playerHand;
	public GameObject gameCamera;
	public GameObject playerHandAndSojiki;
	public Quaternion playerHandAndSojikiQuaternion;
	void Start() {
		// //playerHand.transform.rotation = Quaternion.Euler(0, 0, 0);
		// playerHandAndSojikiQuaternion = playerHandAndSojiki.transform.rotation;
		// playerHandAndSojikiQuaternion.y = gameCamera.transform.rotation.y + 0.7f;
		// playerHandAndSojiki.transform.rotation = playerHandAndSojikiQuaternion;
	}

	void Update() {
		Vector3 cameraPosition = Input.mousePosition;
		cameraPosition.z = 10.0f;
		playerHand.transform.position = Camera.main.ScreenToWorldPoint(cameraPosition);
		// playerHandAndSojikiQuaternion = playerHandAndSojiki.transform.localRotation;
		// playerHandAndSojikiQuaternion.y = gameCamera.transform.localRotation.y + 0.5f;
		// playerHandAndSojiki.transform.localRotation = playerHandAndSojikiQuaternion;


		var angle = gameCamera.transform.rotation.eulerAngles.y + 90.0f;
		angle = angle > 180f ? angle - 360f : angle;
		playerHand.transform.rotation
			= Quaternion.Euler(0f, angle, 0f);
	}
}
