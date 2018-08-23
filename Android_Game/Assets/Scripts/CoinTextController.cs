using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinTextController : MonoBehaviour {
    
    public TextMeshProUGUI coinText;
    private CoinSystem coinSystem;

    public void Setup(CoinSystem coinSystem){
        this.coinSystem = coinSystem;
        coinText.text = "Coins: " + coinSystem.GetCoin();

        coinSystem.OnCoinChanged += CoinSystem_OnCoinChanged;
    }

    private void CoinSystem_OnCoinChanged(object sender, System.EventArgs e) {
        coinText.text = "Coins: " + coinSystem.GetCoin();
        PlayerPrefs.SetInt("PlayerCoinAmount", coinSystem.GetCoin());
    }
}