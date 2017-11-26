using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerConctroll : MonoBehaviour {
	Rigidbody2D r_body;
	public float jump_force;
	public float move_force;
	public bool onLadder;
	public float climbSpeed;
	private float climbVelocity;
	private float gravityStore;

	// Use this for initialization
	void Start () {
		r_body = GetComponent<Rigidbody2D> ();	
		gravityStore = r_body.gravityScale;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			r_body.velocity = new Vector2 (r_body.velocity.x,jump_force);
		}

		if(Input.GetKeyDown(KeyCode.RightArrow)){
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (move_force, 0);
		}

		if(Input.GetKeyDown(KeyCode.LeftArrow)){
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-move_force, 0);
		}

		if(Input.GetKey(KeyCode.RightArrow)){
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (move_force, GetComponent<Rigidbody2D>().velocity.y);
		}

		if(Input.GetKey(KeyCode.LeftArrow)){
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-move_force, GetComponent<Rigidbody2D>().velocity.y);
		}
		if(onLadder && Input.GetKeyDown(KeyCode.UpArrow)){
			r_body.gravityScale = 0.0f;
			climbVelocity = climbSpeed * Input.GetAxisRaw ("Vertical");
			r_body.velocity = new Vector2 (r_body.velocity.x, climbVelocity);
		}
		if(onLadder && Input.GetKeyDown(KeyCode.DownArrow)){
			/*r_body.gravityScale = 0.0f;
			climbVelocity = -climbSpeed * Input.GetAxisRaw ("Vertical");
			r_body.velocity = new Vector2 (r_body.velocity.x, climbVelocity);*/
			r_body.gravityScale = gravityStore/4;
		}
		if (!onLadder) {
			r_body.gravityScale = gravityStore;
		}

	}
	/*
	void FixedUpdate(){
		float h = Input.GetAxis ("Horizontal");
		//if ground, can change horizontal

		r_body.AddForce (new Vector2 (h * move_force, 0));	
	}*/

	void OnCollisionEnter2D(Collision2D other){
		if (other.transform.tag == "movingPlatform") {
			transform.parent = other.transform;
		}
	}

	void OnCollisionExit2D(Collision2D other){
		if (other.transform.tag == "movingPlatform") {
			transform.parent = null;
		}
	}
}
