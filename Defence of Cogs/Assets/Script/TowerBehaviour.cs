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

		GameObject[] enemies = GameObject.FindGameObjectsWithTag ("Enemy");
		if (enemies.Length > 0) 
		{ 
			// find the enemy closest to the tower
			GameObject closest = enemies[0];
			float distToClosest = (closest.transform.position - transform.position).sqrMagnitude;
			foreach(GameObject enemy in enemies)
			{
				float distToCurrent  = (enemy.transform.position - transform.position).sqrMagnitude;
				if (distToCurrent < distToClosest)
				{
					closest = enemy;
					distToClosest = distToCurrent;
				}
			}
			transform.LookAt (closest.transform.position);
			transform.rotation = Quaternion.Euler(new Vector3(0, transform.eulerAngles.y, 0));
		}

		if(Input.GetButton("Fire2"))
		{
			if (enemies.Length > 0) 
			{
				GameObject bullet = Instantiate (projectile);
				bullet.GetComponent<ProjectileBehaviour>().target = enemies[0];
			}
		}
	}
	void OnTriggerEnter (Collider other)
	{
		GameObject bullet = Instantiate (projectile);
		bullet.GetComponent<ProjectileBehaviour> ().target = other.gameObject;
	}
}
