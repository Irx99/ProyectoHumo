using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float velocity = 1;
	public GameObject ship;

	private Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.

	void Start()
	{
		//Get and store a reference to the Rigidbody2D component so that we can access it.
		rb2d = GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate(){
		playerMovement ();
		moveWithShip ();
	}

	private void playerMovement(){
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
		rb2d.velocity = movement * velocity;	
	}

	private void moveWithShip(){
		rb2d.velocity = rb2d.velocity + ship.GetComponent<Rigidbody2D> ().velocity;
		//ship.GetComponent<Rigidbody2D>.velocity
	}
}
