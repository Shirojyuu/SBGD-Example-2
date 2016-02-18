using UnityEngine;
using System.Collections;

public class CoinRotation : MonoBehaviour {

	public float turnSpeed = 90;
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0, 0, turnSpeed * Time.deltaTime);
	}
}
