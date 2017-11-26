using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ladderZone : MonoBehaviour {
	private move theplayer;
	// Use this for initialization
	void Start () {
		theplayer = FindObjectOfType<move> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {
			theplayer.onLadder = true;
		}
	}

	void OnTriggerExit2D(Collider2D other){
		if (other.tag == "Player") {
			theplayer.onLadder = false;
		}
	}


}
