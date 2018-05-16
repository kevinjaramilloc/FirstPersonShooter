using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour 
{
	public GameObject[] prefab;
	public Transform[] spawnPlaces;

	private int index, index2;

	void Start ()
	{
		InvokeRepeating ("Spawn", 5,5);
	}

	void Spawn()
	{
		index = (int) Random.Range (0,prefab.Length);
		index2 = (int) Random.Range (0,spawnPlaces.Length);
		Instantiate (prefab[index], spawnPlaces[index2].position, spawnPlaces[index2].rotation);
	}
}
