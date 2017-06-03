using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomEnter : MonoBehaviour {

	public GameObject enemyManager;
	GameObject player;

	 void Awake ()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	void OnTriggerEnter (Collider other)
	{
		if(other.gameObject == player)
		{
			print ("Enter");
			enemyManager.active = true;
		}
	}
}
