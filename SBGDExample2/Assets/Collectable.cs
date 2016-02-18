using UnityEngine;
using System.Collections;

public class Collectable : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player"){
			Object.Destroy (this.gameObject);
			GameController.Instance.Coins++;
		}
	}
}
