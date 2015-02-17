﻿using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;

	void Start () {
	
		offset = transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = player.transform.position + offset;
	
	}
}
