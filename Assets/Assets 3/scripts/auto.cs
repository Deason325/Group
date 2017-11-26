using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class auto : MonoBehaviour {
	public float end;
	void Update() {
		transform.position = new Vector3(Mathf.PingPong(Time.time, end), transform.position.y, transform.position.z);
	}
}
