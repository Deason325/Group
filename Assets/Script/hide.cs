using UnityEngine;
using System.Collections;

public class hide : MonoBehaviour {

	public GameObject hides;


	void OnCollisionEnter2D(Collision2D coll)
	{
		if (LayerMask.LayerToName (coll.gameObject.layer) == "player") {
			if (Input.GetKey (KeyCode.UpArrow)) {
				hides.layer = LayerMask.NameToLayer ("Default");
				var com = gameObject.GetComponent<PlatformEffector2D> ();
				Destroy (com);
			}
		}
	}
	void OnCollisionStay2D(Collision2D coll)
	{
		if (LayerMask.LayerToName(coll.gameObject.layer) == "player")
		{
			if (Input.GetKey (KeyCode.UpArrow)) {
				var com = gameObject.GetComponent<PlatformEffector2D> ();
				Destroy (com);
			}
	}
}
}

