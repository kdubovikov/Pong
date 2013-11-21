using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed = 0.5F;
	private Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.S)) {
			rigidbody2D.AddForce(new Vector3(0, -speed));
		}
		else if (Input.GetKey(KeyCode.W)) {
			rigidbody2D.AddForce(new Vector3(0, speed));
		}
	}
}
