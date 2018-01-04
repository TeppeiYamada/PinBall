﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour {

	private float visiblePosZ = -6.5f;

	private GameObject gameOverText;

	// Use this for initialization
	void Start () {

		this.gameOverText = GameObject.Find ("GameOverText");

	}
	
	// Update is called once per frame
	void Update () {

		if(this.transform.position.z < visiblePosZ){

			this.gameOverText.GetComponent<Text>().text = "Game Over";

		}
		
	}
}
