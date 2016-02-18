using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour {
	static GameController instance;
	public static GameController Instance {
		get {
			if (instance == null)
				instance = Object.FindObjectOfType<GameController>();
			return instance;
		}
	}

	void Start ()
	{
		Coins = coins;
	}

	public Text coinText;

	[SerializeField]
	int coins;

	public int Coins{
		get{ return coins; }
		set{
			coins = value;
			coinText.text = "Coins: " + coins;
		}
	}
}
