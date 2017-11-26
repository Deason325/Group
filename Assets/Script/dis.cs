using UnityEngine;
using System.Collections;
public class dis : MonoBehaviour {

	void OnGUI () {
		if(GUILayout.Button("Display")){
			gameObject.layer = LayerMask.NameToLayer("Default");
		}

		if(GUILayout.Button("Hide")){
			gameObject.layer = LayerMask.NameToLayer("MyLayer");
		}
	}
}
