using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {
	
	CoinHandler coinHandler;

	private void Start(){
		coinHandler = GameObject.FindGameObjectWithTag("CoinHanlder").GetComponent<CoinHandler>();
	}

	private void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Player"){
			coinHandler.coinSystem.AddCoin(5);
			Destroy(gameObject);
		}
	}
}
