using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScript : MonoBehaviour 
{
	private int damage = 5;
	private float range = 200;
	private float timer;
	private Ray shootRay;
	private RaycastHit hit;

	void Update()
	{

		timer += Time.deltaTime;

		if(Input.GetButton("Fire1") && timer >= 0.1f)
		{
			timer = 0;
			Shoot ();
		}
	}

	void Shoot()
	{
		shootRay.origin = Camera.main.transform.position;
		shootRay.direction = Camera.main.transform.forward;
		if(Physics.Raycast (shootRay.origin, shootRay.direction ,out hit, range, LayerMask.GetMask("Shootable")))
		{
			Enemy enemyMovement = hit.collider.GetComponent<Enemy> ();
			enemyMovement.health -= damage;
		}
	}
}
