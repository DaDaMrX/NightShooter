using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCount : MonoBehaviour {

	public int num = 5;
	public int dead = 0;
	
	void Update () {
		if (dead == num)
		{
			print ("Clear");
		}
	}
}
