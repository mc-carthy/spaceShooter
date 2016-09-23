using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	[SerializeField]
	private float moveSpeed;
	[SerializeField]
	private float xClamp;

	private void Update () {
		PlayerMovement ();
		ClampXMovement ();
	}

	private void PlayerMovement () {
		transform.Translate (new Vector3(Input.GetAxisRaw ("Horizontal"), 0, 0) * moveSpeed);
	}

	private void ClampXMovement () {
		Vector3 temp = transform.position;
		temp.x = Mathf.Clamp (temp.x, -xClamp, xClamp);
		transform.position = temp;
	}
}
