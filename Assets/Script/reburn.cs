using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reburn : MonoBehaviour
{
	private move player;
	public Transform start;

	void Start()
	{
		player = FindObjectOfType<move>();
	}

	void Update()
	{
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			player.transform.position = start.position;
		}
	}
}
