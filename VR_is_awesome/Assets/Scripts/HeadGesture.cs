using UnityEngine;
using System.Collections;
public class HeadGesture : MonoBehaviour {
	public bool isFacingDown = false;
	void Update () {
		isFacingDown = DetectFacingDown ();
	}
	private bool DetectFacingDown () {
		return (CameraAngleFromGround () < 60.0f);
	}
	private float CameraAngleFromGround () {
		return Vector3.Angle (Vector3.down, Camera.main.transform.rotation
		                      * Vector3.forward);
	}
}