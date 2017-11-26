using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallZone : MonoBehaviour {
	private move theplayer;
	public float fall_speed;
	Rigidbody2D r_body;
	// Use this for initialization
	void Start () {
		theplayer = FindObjectOfType<move>();
		r_body = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (theplayer.fall == true) {
			r_body.gravityScale = fall_speed;
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {
			theplayer.fall = true;

		}
	}

	void OnCollisionEnter2D(Collision2D other){
		if (other.transform.tag == "Player") {
			theplayer.fall = false;
			Destroy (other.gameObject);
			Invoke ("load", 2);
			transform.parent.gameObject.AddComponent<end>();
		}
	}
		
}
