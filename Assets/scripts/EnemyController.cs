using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	[SerializeField]
	private ParticleSystem particles;

	[SerializeField]
	private float moveSpeed;

	private void Update () {
		MoveDown ();
	}

	private void MoveDown () {
		transform.Translate (0, -moveSpeed, 0);
	}

	private void OnTriggerEnter2D (Collider2D trig) {
		if (trig.tag == "projectile") {
			Destroy (gameObject);
			SpawnParticles ();
			Destroy (trig.gameObject);
			ScoreController.instance.IncrementScore ();
		}
	}

	private void SpawnParticles () {
		Instantiate (
			particles,
			transform.position,
			Quaternion.identity
		);
	}
}
