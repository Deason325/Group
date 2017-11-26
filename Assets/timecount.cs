using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;


public class timecount : MonoBehaviour {
	// use this for initialization
	public Text timer;





	void Update () {
		timer.text = "Time:" + (int)(Time.time)+"s";

	}
}