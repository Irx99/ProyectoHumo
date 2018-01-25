using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	public int nivelAJugar = 0;
	private string[] nivel = new string[50];
	private string[] nave = new string[50];
	void Awake(){
		DontDestroyOnLoad(transform.gameObject);

		inizializarDatos();
	}

	void OnLevelWasLoaded(int level){
		//Menu online
		if(level == 2){
			GameObject.Find("LobbyManager").GetComponent<NetworkLobbyManager> ().playScene = nivel[nivelAJugar];
		}
	}

	private void inizializarDatos(){
		nivel[0] = "Nivel 0";
		nave[0] = "Nave 0";
	}
}
