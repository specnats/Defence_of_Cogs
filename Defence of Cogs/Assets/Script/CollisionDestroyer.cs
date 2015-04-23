using UnityEngine;
using System.Collections;

public class CollisionDestroyer : MonoBehaviour 
{
	public GameObject follower;
	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "Enemy") {
			Destroy (other.gameObject);
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
