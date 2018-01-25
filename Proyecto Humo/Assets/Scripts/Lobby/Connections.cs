using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Connections : MonoBehaviour {
    
    public bool isAtStartup = true;

	public Text mensaje;
	public InputField ipIntroducida;
    
    NetworkClient myClient;

    void Update () 
    {
        if (isAtStartup)
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                SetupServer();
            }
            
            if (Input.GetKeyDown(KeyCode.C))
            {
                SetupClient();
            }
            
            if (Input.GetKeyDown(KeyCode.B))
            {
                SetupServer();
                SetupLocalClient();
            }
        }
    }
    
    void OnGUI()
    {
        if (isAtStartup)
        {
            GUI.Label(new Rect(2, 10, 150, 100), "Press S for server");     
            GUI.Label(new Rect(2, 30, 150, 100), "Press B for both");       
            GUI.Label(new Rect(2, 50, 150, 100), "Press C for client");
        }
    }   

	 // Create a server and listen on a port
    public void SetupServer()
    {
        NetworkServer.Listen(7777);
        isAtStartup = false;

		//bool useNat = !Network.HavePublicAddress();
        //Network.InitializeServer(50, 7777, useNat); // <- Atencion al primer numero si el online empieza a ir mal

		Debug.Log(Network.player.ipAddress);
		Debug.Log(Network.player.externalIP);

    }

	private int playerCount = 0;
	void OnPlayerConnected(NetworkPlayer player) {
        Debug.Log("Player " + playerCount + " connected from " + player.ipAddress + ":" + player.port);
    }
    
    // Create a client and connect to the server port
    public void SetupClient()
    {
        myClient = new NetworkClient();
        myClient.RegisterHandler(MsgType.Connect, OnConnected);     
        myClient.Connect(ipIntroducida.text, 7777);
		//myClient.Connect("188.76.177.198", 7777);
        isAtStartup = false;
    }
  
    // Create a local client and connect to the local server
    public void SetupLocalClient()
    {
        myClient = ClientScene.ConnectLocalServer();
        myClient.RegisterHandler(MsgType.Connect, OnConnected);     
        isAtStartup = false;
    }

	// client function
    public void OnConnected(NetworkMessage netMsg)
    {
        Debug.Log("Connected to server");
		mensaje.text = "Conectado";
    }
}