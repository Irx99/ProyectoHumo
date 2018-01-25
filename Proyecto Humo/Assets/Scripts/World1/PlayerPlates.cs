using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlates : MonoBehaviour {

	public float velocity = 0.2f;
	public bool isUpPlate;
	public Rigidbody2D spaceShip_rb2d;
	private Vector2 movement = new Vector2(0, 0);

	void OnTriggerEnter2D(Collider2D collider){
		if(isUpPlate){
			movement = movement + new Vector2 (0, 1);
		}else{
			movement = movement + new Vector2 (0, -1);
		}

		spaceShip_rb2d.velocity = movement * velocity;
	}

	void OnTriggerExit2D(Collider2D collider){
		if(isUpPlate){
			movement = movement + new Vector2 (0, -1);
		}else{
			movement = movement + new Vector2 (0, +1);
		}

		spaceShip_rb2d.velocity = movement * velocity;
	}

}
