using UnityEngine;
using System.Collections;

public class ProjectileController : MonoBehaviour {

	[SerializeField]
	private float moveSpeed;

	private void Update () {
		MoveUp ();
	}

	private void MoveUp () {
		transform.Translate (new Vector3 (0, moveSpeed, 0));
	}
}
