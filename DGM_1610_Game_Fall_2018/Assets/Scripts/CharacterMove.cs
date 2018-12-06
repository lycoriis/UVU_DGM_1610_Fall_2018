using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour {

	// Player Movement Variables
	public int MoveSpeed;
	public float JumpHeight;
	private bool DoubleJump;

	// Player Grounded Variables
	public Transform GroundCheck;
	public float GroundCheckRadius;
	public LayerMask WhatIsGround;
	private bool Grounded;

	//Non-Stick Player
	private float MoveVelocity;

	public Animator animator;

	// Use this for initialization
	void Start () {
		animator.SetBool("IsWalking", false);
		animator.SetBool("IsJumping", false);
	}

	void FixedUpdate () {
		Grounded  = Physics2D.OverlapCircle(GroundCheck.position, GroundCheckRadius, WhatIsGround);
	}

	// Update is called once per frame
	void Update () {
		
		//When Spawn, no moving allowed
		// if(animator.GetBool("IsSpawn", true)){
			
		// }

		//This code makes the character jump
		if(Input.GetKeyDown (KeyCode.Space)&& Grounded){
				Jump();
		}

		//DoubleJump Code
		if(Grounded){
			DoubleJump = false;
		}

		if(Input.GetKeyDown (KeyCode.Space)&& !DoubleJump && !Grounded){
			Jump();
			DoubleJump = true;
			animator.SetBool("IsJumping", true);
		}
		else if (Input.GetKeyUp (KeyCode.Space)){
			animator.SetBool("IsJumping", false);
		}

		//Non-Stick Player
		MoveVelocity = 0f;		
		
		//This code makes the character move from side to side using A&D keys
		if(Input.GetKey (KeyCode.D)){
			transform.localScale = new Vector3(0.25f,0.25f,1f);
			MoveVelocity = MoveSpeed;
			animator.SetBool("IsWalking", true);
		}
		else if (Input.GetKeyUp (KeyCode.D)){
			animator.SetBool("IsWalking", false);
		}

		if(Input.GetKey (KeyCode.A)){
			transform.localScale = new Vector3(-0.25f,0.25f,1f);
			MoveVelocity = -MoveSpeed;
			animator.SetBool("IsWalking", true);
		}
		else if (Input.GetKeyUp (KeyCode.A)){
			animator.SetBool("IsWalking", false);
		}
	
		GetComponent<Rigidbody2D>().velocity = new Vector2(MoveVelocity, GetComponent<Rigidbody2D>().velocity.y);
	}

	public void Jump (){
		GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, JumpHeight);
		animator.SetBool("IsJumping", true);
	}
}
