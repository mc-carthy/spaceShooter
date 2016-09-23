using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	[SerializeField]
	private float moveSpeed;
	[SerializeField]
	private float xClamp;
	[SerializeField]
	private GameObject projectile;
	[SerializeField]
	private float firingVelocity = 0.5f;
	[SerializeField]
	private float firingRate = 0.5f;
	private bool isShooting = true;

	private void Start () {
		StartCoroutine (ProjectileShootTimer ());
	}

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

	private IEnumerator ProjectileShootTimer () {
		while (isShooting) {
			yield return new WaitForSeconds (firingRate);
			InstantiateProjectile ();
		}
	}

	private void InstantiateProjectile () {
		Instantiate (projectile, transform.position, Quaternion.identity);
	}
}
