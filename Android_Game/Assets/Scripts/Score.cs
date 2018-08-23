using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour {

    public TextMeshProUGUI scoreText;

    [HideInInspector]
    public int scoreNum = 0;

    void Start() {
        
        scoreText.text = scoreNum.ToString();
    }

    void Update() {
        scoreText.text = scoreNum.ToString();
    }
}
