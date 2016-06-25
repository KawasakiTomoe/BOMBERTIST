using UnityEngine;
using System.Collections;

public class ParticleSortingLayer : MonoBehaviour {

	void Start (){


		ParticleSystem ps = GetComponent<ParticleSystem> ();
		// Set the sorting layer of the particle system.
		ps.GetComponent<Renderer>().sortingOrder = 3;
	}
}