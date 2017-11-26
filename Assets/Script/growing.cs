using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class growing : MonoBehaviour {
	private bool grow = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.localScale.x > 5) {
			grow = false;
		}

	}




	void OnCollisionEnter2D(Collision2D coll){
		if (coll.transform.tag == "Player" && grow == true) {
		//	this.transform.localScale += new Vector3 (1, 1, 1);
			Vector3 scale = this.transform.localScale;
			this.transform.localScale = new Vector3 (scale.x + 1, scale.y, scale.z);
		}
		if (coll.transform.tag == "Player" && grow == false) {
			Destroy (this.gameObject);
		}
	}
}
