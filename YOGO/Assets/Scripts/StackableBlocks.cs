using UnityEngine;
using System.Collections;

public class StackableBlocks : MonoBehaviour {

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
		if(collision.relativeVelocity.magnitude > 2)
		{
			Destroy(gameObject);

			//reset it on collision in the case of multiple cascading objects
			GameStateManager.ResetCountdown();
			GameStateManager.BlockBroken();
		}
	}
}
