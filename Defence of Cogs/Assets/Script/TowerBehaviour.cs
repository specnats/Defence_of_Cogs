using UnityEngine;
using System.Collections;

public class TowerBehaviour : MonoBehaviour {

	public GameObject projectile;
	public GameObject enemyPlaceholder;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.LookAt (enemyPlaceholder.transform.position);
	
	}

	void OnTriggerEnter () {

		GameObject bullet = Instantiate (projectile);
		projectile.transform.position = transform.position;
		projectile.transform.forward = transform.forward;
	}
}
