﻿using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {

	public int speed = 5;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (speed * Time.deltaTime, speed * Time.deltaTime, speed * Time.deltaTime));
	}
}
