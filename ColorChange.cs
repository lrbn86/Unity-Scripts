using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {

	float timeLeft;
	Color targetColor;

	Color [] colors = {Color.grey, Color.magenta, Color.black};

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (timeLeft <= Time.deltaTime) {
			GetComponent<Renderer>().material.color = targetColor;
			targetColor = colors[Random.Range(0,2)];
			timeLeft = 1.0f;
		} else {
			GetComponent<Renderer>().material.color = Color.Lerp(GetComponent<Renderer>().material.color, targetColor, Time.deltaTime / timeLeft);
			timeLeft -= Time.deltaTime;
		}
	}
}
