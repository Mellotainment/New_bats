﻿using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {

	public AudioSource roar; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			transform.position += new Vector3 (0, 0, 1);
		}

		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			transform.position += new Vector3 (0, 0, -1);
		}
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			transform.position += new Vector3 (-1, 0, 0);
		}
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			transform.position += new Vector3 (1, 0, 0);
		}
		    
		if (Input.GetButtonDown("Fire1")){
			Debug.Log ("katty");
			roar = GetComponent<AudioSource>();
			roar.Play();

	}
	}
}
