using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap : MonoBehaviour {
	public Transform start;

	void Start()
	{
		
	}

	void Update()
	{
	}


	// let the player die
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			Destroy (other.gameObject);
			Invoke ("load", 2);
			transform.parent.gameObject.AddComponent<end>();		
		}
	}
}