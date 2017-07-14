using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StartAnimation : MonoBehaviour {
	//public Animation StartAnim;

	Animator animator;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		animator.Play ("TestAnim");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
