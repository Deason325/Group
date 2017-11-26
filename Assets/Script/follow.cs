using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour {

	public Transform trackingTarget;
	public float followSpeed;
	public float xOffset;
	public float yOffset;


	void Update()
	{
		if (trackingTarget != null) {
			transform.position = new Vector3 (trackingTarget.position.x,
				-1, transform.position.z);
			float xTarget = trackingTarget.position.x + xOffset;
			float yTarget = trackingTarget.position.y + yOffset;

			float xNew = Mathf.Lerp (transform.position.x, xTarget, Time.deltaTime * followSpeed);
			float yNew = Mathf.Lerp (transform.position.y, yTarget, Time.deltaTime * followSpeed);

			transform.position = new Vector3 (xNew, yNew, transform.position.z);
		}
	}
}