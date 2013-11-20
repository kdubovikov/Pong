using UnityEngine;
using System.Collections;

public class AIscoreTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collider) {
		Application.LoadLevel (Application.loadedLevelName);
		Score.aiScore++;
	}
}
