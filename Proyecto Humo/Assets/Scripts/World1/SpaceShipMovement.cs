using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipMovement : MonoBehaviour {

	public Collider2D insideCollider;
	public Collider2D upPlate;
	public Collider2D downPlate;

	public Collider2D actual;
	private PlayerController playerController;

	void OnTriggerEnter2D(Collider2D collider){
		actual = collider;
		Debug.Log("1");
		if(collider == insideCollider){
			Debug.Log("Entro");
			playerController.isInside();
		}
		if(collider == upPlate){
			Debug.Log("Pa arriba");
			playerController.isInside();
		}
		if(collider == downPlate){
			Debug.Log("Pa abajo");
			playerController.isInside();
		}
	}

	void OnTriggerExit2D(Collider2D collider){
		Debug.Log("2");
		if(collider == insideCollider){
			Debug.Log("Salgo");
			playerController.isOutside();
		}
		if(collider == upPlate){
			Debug.Log("Stop subir");
			playerController.isInside();
		}
		if(collider == downPlate){
			Debug.Log("Stop bajar");
			playerController.isInside();
		}
	}
}
