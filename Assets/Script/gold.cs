using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;


public class gold : MonoBehaviour {
	// use this for initialization
	public Text Score;
	public int golds = 0;
	public static gold ui_number;



	void Awake()
	{
		ui_number = this;
	}

	void Update () {
		//Score.text = "gold:" + golds;

	}
}