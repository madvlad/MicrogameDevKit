using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    public Text timeCanvas;


    float timeLeft = 8.0f;
	
	void FixedUpdate () {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timeCanvas.text = Mathf.Ceil(timeLeft).ToString();
        }
	}
}
