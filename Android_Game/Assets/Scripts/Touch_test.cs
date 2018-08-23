using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Touch_test : MonoBehaviour {

    public Text numberOfTouches;
	// Update is called once per frame
	void Update () {
        numberOfTouches.text = Input.touchCount.ToString();
	}
}
