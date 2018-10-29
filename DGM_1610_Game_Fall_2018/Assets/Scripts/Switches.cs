using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour {

	public int Num;
	public string Name;

	// Use this for initialization
	void Start () {
		
		// if(Num == 10)
		// 	print("Hurray you picked ten!");
		
		// else
		// 	print("Boo! You didn't pick ten!");
		
		
	// switch(Num){

	// 	case 1:
	// 		print("You picked" + Num );
	// 	break;

	// 	case 3:
	// 		print("You picked" + Num );
	// 	break;

	// 	case 6:
	// 		print("You picked" + Num );
	// 	break;

	// 	case 10:
	// 		print("You picked" + Num );
	// 	break;

	// 	default:
	// 		print("I don't understand" + Num);
	// 	break;

	// 	}

		switch(Name){
			case "Jason":
				print("Welcome to Camp Crystal Lake " + Name);
			break;

			case "Michael":
				print("Welcome to Haddonfield, Illinois " + Name);
			break;

			case "Freddie":
				print("Welcome to Elm Street " + Name);
			break;

			case "Leatherface":
				print("The stars and stripes are big at night... Deep in the heart of Texas " + Name);
			break;

			default:
				print("I don't know " + Name);
			break;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
