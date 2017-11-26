using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coliect : MonoBehaviour {

	public AudioSource bling;

	void Start () {
	}

	void Update () {
	}


	// collect the gold which the player get
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			Destroy(gameObject);
			bling.Play();
			gold.ui_number.golds++;
		}
	}
}