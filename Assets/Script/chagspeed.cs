using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chagspeed : MonoBehaviour {

	public AudioSource bling;
	public GameObject player;
	public float speed;


	void Start () {
	}

	void Update () {
	}



	// change the speed of the player
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			Destroy(gameObject);
			bling.Play();
			player.SendMessage ("changespeed", speed);
		}
	}
}