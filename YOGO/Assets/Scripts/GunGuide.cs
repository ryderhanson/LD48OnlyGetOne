using UnityEngine;
using System.Collections;

public class GunGuide : MonoBehaviour {

	public float guideDistance = 3.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetAxis("Mouse ScrollWheel") < 0) //back
		{
			guideDistance -= 10.0f * Time.deltaTime;
		}
		else if(Input.GetAxis("Mouse ScrollWheel") > 0) //forward
		{
			guideDistance += 10.0f * Time.deltaTime;
		}

		Vector3 newPos = Input.mousePosition;
		//newPos.z = transform.position.z - Camera.main.transform.position.z;
		transform.position = Camera.main.ScreenToWorldPoint(new Vector3(newPos.x, newPos.y, guideDistance));
	}
}
