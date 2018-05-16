using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour 
{
private NavMeshAgent navigation;
	private GameObject player;
	private PlayerHealth playerHealth;
	private bool isDead = false;
	private float timer;

	public float timeBetweenAttacks = 1.2f;
	public int damage;
	public int health = 100;

	void Start ()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
		playerHealth = player.GetComponent<PlayerHealth> ();
		navigation = GetComponent<NavMeshAgent> ();

	}


	void Update () 
	{
		if (health > 0)
		{
			navigation.SetDestination (player.transform.position);
		}

		else if (health > 0)
		{
			timer += Time.deltaTime;

			if(timer >= timeBetweenAttacks)
			{
				Debug.Log ("ouch");
				playerHealth.health -= damage;
				timer = 0f;
			}
		}

		else if(health <= 0)
		{
			navigation.Stop ();
			if(!isDead)
			{
				isDead = true;
				Destroy (gameObject, 5f);
			}

		}

	}
}
