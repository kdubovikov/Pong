﻿using UnityEngine;
using System.Collections;

public class PlayerScoreTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collider) {
		Score.playerScore++;
		Application.LoadLevel(Application.loadedLevelName);
	}
}
