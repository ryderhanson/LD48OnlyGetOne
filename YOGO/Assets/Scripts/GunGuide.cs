using UnityEngine;
using System.Collections;

public class GunGuide : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		Vector3 newPos = Input.mousePosition;
		//newPos.z = transform.position.z - Camera.main.transform.position.z;
		transform.position = Camera.main.ScreenToWorldPoint(new Vector3(newPos.x, newPos.y, 3.0f));
	}
}
