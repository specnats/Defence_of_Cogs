using UnityEngine;
using System.Collections;

public class ProjectileBehaviour : MonoBehaviour {

	public GameObject target;
	// Use this for initialization

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (target != null)
		{
			Vector3 targetForward = (target.transform.position - transform.position).normalized;
			
			//Quarternion rotation = (new Vector3(0,transform.eulerAngles.y + 90, 0))
			
			transform.position += targetForward * 25f * Time.deltaTime;
		}
	}
}
