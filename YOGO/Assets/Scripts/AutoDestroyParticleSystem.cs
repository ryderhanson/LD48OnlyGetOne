﻿using UnityEngine;
using System.Collections;

public class AutoDestroyParticleSystem : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(gameObject.GetComponent<ParticleSystem>().isPlaying == false)
		{
			Destroy(gameObject);
		}
	}
}
