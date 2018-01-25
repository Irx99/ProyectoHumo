using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class PlayerController : NetworkBehaviour {

	public float velocity = 1;
	public GameObject ship;
	public Sprite localPlayer;

	private Camera mainCamera;

	private Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.


	void Start()
	{
		//Get and store a reference to the Rigidbody2D component so that we can access it.
		rb2d = GetComponent<Rigidbody2D> ();
	}

	public override void OnStartLocalPlayer()
    {
		//TODO: Aspecto personalizado para cada jugador, al azar o pre-seleccionado
		this.GetComponent<SpriteRenderer> ().sprite = localPlayer;

		InitializeCamera();
    }

	private void InitializeCamera(){
		mainCamera = GameObject.Find("Main Camera").GetComponent<Camera> ();
		mainCamera.GetComponent<CameraController> ().setPlayer(this.gameObject);
	}

	void Update(){

		if (!isLocalPlayer)
        {
            return;
        }

		playerMovement ();
		//moveWithShip ();
	}

	private void playerMovement(){
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
		rb2d.velocity = movement * velocity;	
	}

/*
	private void moveWithShip(){
		rb2d.velocity = rb2d.velocity + ship.GetComponent<Rigidbody2D> ().velocity;
		//ship.GetComponent<Rigidbody2D>.velocity
	}
*/
}
