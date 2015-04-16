using UnityEngine;
using System.Collections;

public class MousePosRaycastTes : MonoBehaviour {

	public Camera mainCamera;
	public GameObject tower;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetButtonDown("Fire1"))
		{
			RaycastHit rHit = new RaycastHit();
			Ray rRay = mainCamera.ScreenPointToRay(Input.mousePosition);
			if(Physics.Raycast(rRay, out rHit, 1000))
			{
				Debug.Log("Got a hit!");
				GameObject instance = Instantiate(tower);
				instance.transform.position = rHit.point;
				//Screen.showCursor
			}

		}
	
	}
}
