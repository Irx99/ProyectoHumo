using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class InsideSpaceShip : NetworkBehaviour {

	void OnTriggerEnter2D(Collider2D collider){
		Debug.Log("Hola");
		collider.GetComponent<PlayerController>().isInside();		
	}

	void OnTriggerExit2D(Collider2D collider){
		Debug.Log("Adios");
		collider.GetComponent<PlayerController>().isOutside();
	}
}
