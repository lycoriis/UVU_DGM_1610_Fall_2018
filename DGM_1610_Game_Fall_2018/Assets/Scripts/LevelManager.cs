using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public GameObject CurrentCheckPoint
	private Controller2D Player;

	//Particles
	public GameObject DeathParticle;
	public GameObject RespawnParticle;

	//Respawn Delay
	public float RespawnDelay;

	//Point Penalty on death
	public int PointPenaltyOnDeath;

	//Store Gravity Value
	private float GravityStore;

	//Use this for initialization
	void Start () {
		Player = FindObjectOfType<Rigidbody2D> ();
	}

	public void RespawnPlayer (){
		StartCoroutine ("RespawnPlayerCo")
	}

	public IEnumerator RespawnPlayerCo (){
		//Generate Death Particles
		Instantiate (DeathParticle, Player.Transform.Position, Player.transform.rotation)

		//Hide Player
		Player.enabled = false;
		Player.GetComponent<Renderer> ().enabed = false;
		
		//Gravity Reset
		GravityStore = Player.GetComponent<Rigidbody2D>().GravityScale;
		Player.GetComponent<Rigidbody2D>().GravityScale = 0f;
		Player.GetComponent<Rigidbody2D>().Velocity = Vector2.zero;

		//Point Penalty
		ScoreManager.AddPoints(-PointPenaltyOnDeath);

		//Debug Message
		Debug.Log ("Player Respawn");
		

	}


	
	}
