using UnityEngine;
using System.Collections;

public class MousePosRaycastTes : MonoBehaviour {

	public Camera mainCamera;
	public GameObject tower;

	public float towersInInventory = 10f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetButtonDown("Fire1") && towersInInventory > 0)
		{
			RaycastHit rHit = new RaycastHit();
			Ray rRay = mainCamera.ScreenPointToRay(Input.mousePosition);
			if(Physics.Raycast(rRay, out rHit, 1000))
			{
				Debug.Log("Got a hit!");
				GameObject instance = Instantiate(tower);
				instance.transform.position = rHit.point;
				towersInInventory -= 1;
				//instance.transform.position.y += 6;
				//Screen.showCursor
			}

		}
	
	}
}
