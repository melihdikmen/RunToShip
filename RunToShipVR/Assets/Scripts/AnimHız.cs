using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimHız : MonoBehaviour {
	private Animator anim;
	public float speed=0.6f;

	// Use this for initialization
	void Start () {
		
		anim = GetComponent<Animator> ();
		anim.speed = speed;
	}
	 
	// Update is called once per frame
	void Update () {
		
	}


}
