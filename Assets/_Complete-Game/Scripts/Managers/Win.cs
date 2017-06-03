using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour {

	GameObject canvas;
	Animator anim;

	void Awake ()
	{
		canvas = GameObject.Find("HUDCanvas");
		anim = canvas.GetComponent <Animator> ();
	} 

	void OnDestroy ()
	{
		anim.SetTrigger("Win");
		print ("Des");
	}
}
