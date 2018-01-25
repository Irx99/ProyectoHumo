using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	private GameObject player;       //Public variable to store a reference to the player game object

    private Vector2 offset;         //Private variable to store the offset distance between the player and camera

    public void setPlayer(GameObject player){
        this.player = player;
    }
  
    // LateUpdate is called after Update each frame
    void LateUpdate () 
    {
        // Set the position of the camera's transform to be the same as the player's.
        transform.position = new Vector3 (player.transform.position.x, player.transform.position.y, transform.position.z);
    }
}
