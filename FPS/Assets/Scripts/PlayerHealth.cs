using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour 
{
	public int health = 100;
	public GameObject mainCamera;
	void Update () 
	{

		if(health <= 0 )
		{
			mainCamera.SetActive(false);
		}
	}
}
