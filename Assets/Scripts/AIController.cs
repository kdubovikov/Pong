using UnityEngine;
using System.Collections;

public class AIController : MonoBehaviour {
	public float speed = 25.0f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		float destination = GameObject.FindGameObjectWithTag("Ball").rigidbody2D.transform.position.y;
		float ballx = GameObject.FindGameObjectWithTag("Ball").rigidbody2D.transform.position.x;

		if (!collider2D.OverlapPoint(new Vector2(transform.position.x, destination)) && 
		    ballx >= 0.5) {
			if (transform.position.y > destination){
				rigidbody2D.AddForce(new Vector3(0, -speed));
			} 
			else if (transform.position.y < destination) {
				rigidbody2D.AddForce(new Vector3(0, speed));
			}
		}
	}
}
