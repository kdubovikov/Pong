using UnityEngine;
using System.Collections;

public class ScoreTrigger : MonoBehaviour {
	public enum WhoScores {Player, AI};
	public WhoScores whoScores;

	public GameObject ballPrefab;

	void Start () {
	}

	void Update () {
	}

	void OnTriggerEnter2D(Collider2D collider) {
		switch (whoScores)
		{
			case WhoScores.AI:
				Score.aiScore++;
				break;
			case WhoScores.Player:
				Score.playerScore++;
				break;
		}

		collider.gameObject.rigidbody2D.velocity = Vector3.zero;
		collider.gameObject.GetComponent<Animator>().SetTrigger("Dead");
		Destroy(collider.gameObject, 2.0F);
		Instantiate(ballPrefab, new Vector3(), Quaternion.identity);
	}
}
