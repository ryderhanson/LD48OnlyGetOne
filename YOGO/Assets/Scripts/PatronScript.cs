using UnityEngine;
using System.Collections;

public class PatronScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void HitByGun()
	{
		Destroy(gameObject);
	}

	public void AimedAt()
	{
		//Destroy(gameObject);
	}
}
