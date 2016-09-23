using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	[SerializeField]
	private float moveSpeed;

	private void Update () {
		MoveDown ();
	}

	private void MoveDown () {
		transform.Translate (0, -moveSpeed, 0);
	}
}
