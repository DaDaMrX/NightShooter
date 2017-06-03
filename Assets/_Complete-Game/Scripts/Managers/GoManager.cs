using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoManager : MonoBehaviour {

	EnemyCount enemyCount;
	
        
	public Animator anim;

	void Awake ()
	{
		enemyCount = GetComponent <EnemyCount> ();
	}

	void Update ()
	{
		if(enemyCount.dead == enemyCount.num)
		{
			enemyCount.dead = 0;
			anim.SetTrigger ("Go");
		}
	}
}
