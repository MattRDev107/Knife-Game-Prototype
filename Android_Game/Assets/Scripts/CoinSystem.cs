using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSystem {
	
	public event EventHandler OnCoinChanged;
	private int coin; 
	private int coinMax = 9999;

	public CoinSystem(int coinAmount){
		coinAmount = coin;
	} 

	public int GetCoin(){
		return coin;
	}

	public void AddCoin(int AddCoinAmount){
		coin += AddCoinAmount;
		if(coin > coinMax) coin = coinMax;
		if(OnCoinChanged != null) OnCoinChanged(this, EventArgs.Empty);
	}

	public void TakeAwayCoin(int TakeCoinAmount){
		coin -= TakeCoinAmount;
		if(coin < 0) coin = 0;
		if(OnCoinChanged != null) OnCoinChanged(this, EventArgs.Empty);
	}
}
