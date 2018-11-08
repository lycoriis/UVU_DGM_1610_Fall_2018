using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

	public float Speed;

	public Rigidbody2D PC;

	public GameObject EnemyDeath;

	public GameObject ProjectileParticle;

	public int PointsForKill;

	// Use this for initialization
	void Start () {
		
		if(PC.transform.localScale.x < 0)
			Speed = -Speed;

			//Speed = Speed * Mathf.Sign(PC.transform.localScale.x);
			// GetComponent<Rigidbody2D().velocity = new Vector2(speed + PC.GetComponent)<Rigidbody2D
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D>().velocity = new Vector2(Speed, GetComponent<Rigidbody2D>().velocity.y);
		
	}
	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.tag == "Enemy"){
			Instantiate(EnemyDeath, other.transform.position, other.transform.rotation);
			Destroy (other.gameObject);
			ScoreManager.AddPoints (PointsForKill);
		}
	
		Destroy (gameObject);
	}
	
	void OnCollisionEnter2D(Collision2D other){
		Instantiate(ProjectileParticle, transform.position, transform.rotation);
		Destroy (gameObject, 1);
	}
}
