using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour {

	// Player Movement Variables
	public int MoveSpeed;
	public float JumpHeight;

	// Player Grounded Variables
	public Transform GroundCheck;
	public float GroundCheckRadius;
	public LayerMask WhatIsGround;
	private bool Grounded;

	// Use this for initialization
	void Start () {
		print("Hello World!");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
