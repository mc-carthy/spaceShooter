using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

	[SerializeField]
	private GameObject enemyPrefab;
	[SerializeField]
	private bool isSpawning = true;
	[SerializeField]
	private float spawnRate = 1;
	[SerializeField]
	private float xClamp = 24;
	[SerializeField]
	private float yMax = 12;

	private void Start () {
		StartCoroutine(SpawnEnemyTimer ());
	}

	private IEnumerator SpawnEnemyTimer () {
		while (isSpawning) {
			yield return new WaitForSeconds (spawnRate);
			InstantiateEnemy ();
		}
	}

	private void InstantiateEnemy () {
		Instantiate (
			enemyPrefab,
			new Vector3 (Random.Range (-xClamp, xClamp), yMax, 0),
			Quaternion.identity
		);
	}
}
