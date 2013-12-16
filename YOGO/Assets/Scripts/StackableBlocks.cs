using UnityEngine;
using System.Collections;

public class StackableBlocks : MonoBehaviour {

	public GameObject pSystem;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void HitByGun()
	{
		Destroy(gameObject);
	}

	public void AimedAt()
	{

	}

	void OnCollisionEnter( Collision collision )
	{
		/*if(other.tag == "DestroyBlock")
		{

		}*/
		if(collision.relativeVelocity.magnitude > 1.5)
		{
			Instantiate(pSystem, transform.position, transform.rotation);

			Destroy(gameObject);

			//reset it on collision in the case of multiple cascading objects
			GameStateManager.ResetCountdown();
			GameStateManager.BlockBroken();
		}
	}
}
