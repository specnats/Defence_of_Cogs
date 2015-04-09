﻿using UnityEngine;
using System.Collections;

public class CameraBehaviour : MonoBehaviour {

	public float x = 0f;
	public float z = 0f;
	public float y = 20f;

	private float translationSpeed = 5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		//fix this so it will move according to x rotation so we can have rotation with the camera too and produce interesting and noy boring camrera angles.	
		float verticalMovement = Input.GetAxisRaw ("Vertical") * 7f;
		float horizontalMovement = Input.GetAxisRaw ("Horizontal") *7f;
		float cameraZoomChange = Input.GetAxisRaw ("CameraY") * 5f;

		//z += verticalMovement;
		//x += horizontalMovement;
		//y += cameraZoomChange;


		Vector3 camZoom = transform.up;
		Vector3 camHorizontal = transform.right;
		Vector3 camVertical = transform.forward;

		//transform.position = new Vector3(x, y, z);
		transform.Translate (camZoom * cameraZoomChange * Time.deltaTime);
		transform.Translate (camHorizontal * horizontalMovement * Time.deltaTime);
		transform.Translate (camVertical * verticalMovement * Time.deltaTime);

		//transform.for
	
	}
}
