using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipMovement : MonoBehaviour {

	public float velocity = 0.2f;

	public Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.
	public bool upPlate = false;

	private Vector2 movement;

	void OnTriggerStay2D(Collider2D collider){

		if (upPlate) {
			movement = new Vector2 (0, 1);
		} else {
			movement = new Vector2 (0, -1);
		}

		rb2d.velocity = movement * velocity;
	}

	void OnTriggerExit2D(Collider2D collider){
		rb2d.velocity = new Vector2 (0, 0);
	}
}
