﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounce : MonoBehaviour {

	public float boost;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnCollisionEnter2D(Collision2D other)
	{
		other.rigidbody.AddForce(Vector2.up * boost, ForceMode2D.Impulse);

		// set x value of new force vector to 0.0f, if you need the jump was straight up
	}
}
