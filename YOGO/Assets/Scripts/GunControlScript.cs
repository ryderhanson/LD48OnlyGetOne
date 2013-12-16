using UnityEngine;
using System.Collections;

public class GunControlScript : MonoBehaviour 
{
	public float rotateSpeed = 1.0f;
	public GameObject guide;
	public GameObject barrelTip;

	private bool _hasFired = false;


	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetMouseButtonDown(0))
		{
			//if(_hasFired == false)
			//{
				Fire();
				//_hasFired = true;
			//}
		}
		else
		{
			TakeAim();
		}


		transform.LookAt(guide.transform.position);
	}

	void Fire()
	{
		GameStateManager.ShotFired();

		GameObject hitObject = FindRaycastedObject();
		if(hitObject != null)
		{
			if(_hasFired == false)
			{
				GetComponent<AudioSource>().Play();
				hitObject.BroadcastMessage("HitByGun", SendMessageOptions.DontRequireReceiver);
				_hasFired = true;
			}
		}
	}

	void TakeAim()
	{
		GameObject hitObject = FindRaycastedObject();
		if(hitObject != null)
		{
			hitObject.BroadcastMessage("AimedAt", SendMessageOptions.DontRequireReceiver);
		}


	}

	GameObject FindRaycastedObject()
	{
		RaycastHit[] hits = Physics.RaycastAll(barrelTip.transform.position, guide.transform.position - barrelTip.transform.position);
		
		if(hits.Length == 0)
		{
			return null;
		}
		
		RaycastHit closest = hits[0];
		
		foreach(RaycastHit hit in hits)
		{
			if(closest.distance > hit.distance)
			{
				closest = hit;
			}
		}

		return closest.collider.gameObject;
	}
}
