using UnityEngine;
using System.Collections;

public class SpawnController : MonoBehaviour {
	public GameObject follower;
	public int x, y, z;
	public float nextEnemyTime; // when spawn the next enemy
	public float enemyFrequencySecs = 1; 


	void Start () {
		nextEnemyTime = Time.time;
	}
	

	// Update is called once per frame
	void Update () {

		if (nextEnemyTime < Time.time) {
			Instantiate (follower, new Vector3 (x, y, z), Quaternion.identity);
			nextEnemyTime = Time.time + enemyFrequencySecs;
		}

	}

}
