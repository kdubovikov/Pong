using UnityEngine;
using System.Collections;

public class PlayerScoreTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collider) {
		collider.gameObject.rigidbody2D.velocity = Vector3.zero;
		collider.gameObject.GetComponent<Animator>().SetTrigger("Dead");
		Score.playerScore++;
	}
}
