using UnityEngine;
using System.Collections;

public class GunControlScript : MonoBehaviour 
{
	public float rotateSpeed = 1.0f;
	public GameObject guide;

	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () 
	{
		/*Vector3 eulerRotation = new Vector3();

		//Rotating at the same time is bad
		if(Input.GetKey(KeyCode.A))
		{
			eulerRotation.y += rotateSpeed;
		}
		else if(Input.GetKey(KeyCode.D))
		{
			eulerRotation.y -= rotateSpeed;
		}
		else if(Input.GetKey(KeyCode.W))
		{
			eulerRotation.x += rotateSpeed;
		}
		else if(Input.GetKey(KeyCode.S))
		{
			eulerRotation.x -= rotateSpeed;
		}
		
		
		transform.Rotate(eulerRotation);*/

		transform.LookAt(guide.transform.position);
	}

	void Flip()
	{

	}
}
