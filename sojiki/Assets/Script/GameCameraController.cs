﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCameraController : MonoBehaviour {
	public GameObject targetObj;
	public Vector3 targetPos;

	void Start() {
		targetPos = targetObj.transform.position;
	}

	void Update() {
		// targetの移動量分、自分（カメラ）も移動する
		transform.position += targetObj.transform.position - targetPos;
		targetPos = targetObj.transform.position;
 
		if (Input.GetMouseButton(1)) {
			float mouseInputX = Input.GetAxis("Mouse X");
			float mouseInputY = Input.GetAxis("Mouse Y");
			
			// targetの位置のY軸を中心に、回転（公転）する
			transform.RotateAround(targetPos, Vector3.up, mouseInputX * Time.deltaTime * 200f);
		}
	}
}
