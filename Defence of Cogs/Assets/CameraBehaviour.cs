using UnityEngine;
using System.Collections;

public class CameraBehaviour : MonoBehaviour {

	public float x = 0f;
	public float z = 0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
			z += Input.GetAxisRaw ("Vertical") * 0.2f;
			x += Input.GetAxisRaw ("Horizontal") * 0.2f;

		transform.position = new Vector3(x, 10, z);
	
	}
}
