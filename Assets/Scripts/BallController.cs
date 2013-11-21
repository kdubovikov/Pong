using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {
	public float startingSpeed = 3.0F;
	public float acceleration = 0.1F;
	public float maxSpeed = 6.0F;

	// Use this for initialization
	void Start () {
		rigidbody2D.velocity = new Vector2(1, -1) * startingSpeed;
		Debug.Log(rigidbody2D.velocity);
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter2D(Collision2D collision) {
		rigidbody2D.velocity = Vector3.Reflect(collision.relativeVelocity, collision.contacts[0].normal);

		if (acceleration < maxSpeed) {
			rigidbody2D.velocity += new Vector2(acceleration, acceleration);
		}

		if (rigidbody2D.velocity.y == 0) {
			rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, Random.value * 2 - 1);
		}
	}
}
