using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chagsize : MonoBehaviour {

	public AudioSource bling;
	public GameObject player;
	public float x;
	public float y;

	void Start () {
	}

	void Update () {
	}


	//change the size of player
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			Destroy(gameObject);
			bling.Play();
			player.transform.localScale=(new Vector2(x,y));
		}
	}
}