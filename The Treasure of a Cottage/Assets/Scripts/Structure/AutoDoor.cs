﻿using UnityEngine;
using System.Collections;

public class AutoDoor : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay(){
		transform.rotation *= Quaternion.AngleAxis (30.0f * Time.deltaTime, new Vector3 (0, 1, 0));
	}
}
