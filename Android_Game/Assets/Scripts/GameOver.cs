using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOver : MonoBehaviour {

	public TextMeshProUGUI gameOver;
	public GameObject Button;
    
	[HideInInspector]
	public bool knifeHitAnotherKnife = false;
	private GameObject fadeBackgrouded;

	void Start() {
		Button.SetActive(false);
		gameOver.text = "";
		fadeBackgrouded = GameObject.FindGameObjectWithTag("Fade");
		fadeBackgrouded.gameObject.SetActive(false);
	}

	void Update () {
		if(knifeHitAnotherKnife){
			fadeBackgrouded.gameObject.SetActive(true);
			gameOver.text = "Game Over";
			Button.SetActive(true);
		}
	}

	public void Restart(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		Handheld.Vibrate();
	}
}
