using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {
	public float speed = 1.0F;
	private float _acceleration = 1.0F;

	// Use this for initialization
	void Start () {
		rigidbody2D.velocity = new Vector2(1, -1) * speed;
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D(Collision2D collision) {
		_acceleration += 0.01F;
		rigidbody2D.velocity = Vector3.Reflect(collision.relativeVelocity, collision.contacts[0].normal) * _acceleration;

		if (rigidbody2D.velocity.y == 0) {
			rigidbody2D.velocity += new Vector2(0, Random.value * 2 - 1);
		}
	}
}
