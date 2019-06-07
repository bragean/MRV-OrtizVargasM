using UnityEngine;
using System.Collections;
public class Rotator : MonoBehaviour {
	public float xRate = 0; // degrees per second
	public float yRate = 20;
	public float zRate = 0;
	void Update () {
		transform.Rotate (new Vector3 (xRate, yRate, zRate) *
		                  Time.deltaTime);
	}
}