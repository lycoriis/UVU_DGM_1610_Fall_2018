using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoManager : MonoBehaviour {

	public static int Ammo;

	Text AmmoText;

	// Use this for initialization
	void Start () {
		AmmoText = GetComponent<Text>();
		Ammo = 1;
	}
	
	// Update is called once per frame
	void Update () {
		//If Ammo goes below 0 it stays at 0, need to figure out RESPAWN/Death
		if (Ammo <= 0){
			Ammo = 0;
			// NEED TO DISABLE PROJECTILE SCRIPT HERE
		}
		
		//Ammo renable when 1 or more
		if (Ammo >= 1){
			// NEED TO ENABLE PROJECTILE SCRIPT HERE
		}
		
		//Ammo cannot go higher than 3
		if (Ammo > 3){
			Ammo = 3;
		}
		//UI
		AmmoText.text = " " + Ammo;

	}

	public static void AddPoints (int AmmoToAdd) {
		Ammo += AmmoToAdd;
	}
}
