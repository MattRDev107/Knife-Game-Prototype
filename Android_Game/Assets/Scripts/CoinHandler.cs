using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinHandler : MonoBehaviour {

	public CoinSystem coinSystem;
	private CoinTextController coinTextController;

	void Start () {
		coinTextController = GameObject.Find("Canvas").GetComponent<CoinTextController>();

		coinSystem = new CoinSystem(0);

		coinTextController.Setup(coinSystem);
	}
}
