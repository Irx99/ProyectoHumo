using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipController : MonoBehaviour {

	public float velocity = 0.2f;

	public GameObject upPlate;
	public GameObject downPlate;

	private Rigidbody2D spaceShip_rb2d;
	private Vector2 movement;

	void Start()
	{
		spaceShip_rb2d = GetComponent<Rigidbody2D> ();
	}

	void OnTriggerStay2D(Collider2D collider){

		if (collider == upPlate) {
			movement = new Vector2 (0, 1);
		}
		if (collider == downPlate) {
			movement = new Vector2 (0, -1);
		}

		spaceShip_rb2d.velocity = movement * velocity;
	}

	void OnTriggerExit2D(Collider2D collider){
		spaceShip_rb2d.velocity = new Vector2 (0, 0);
	}
}
