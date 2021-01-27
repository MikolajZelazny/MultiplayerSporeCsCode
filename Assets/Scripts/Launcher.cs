using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;


public class Launcher : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Connected to Master");
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster() 
    {
        //base.OnConnectedtoMaster(); check
        Debug.Log("Connected to Master");
        PhotonNetwork.JoinLobby();
    }

public override void OnJoinedLobby()
{
        MenuManager.Instance.OpenMenu("title");
        Debug.Log("Joined Lobby");
}


// Update is called once per frame
void Update()
{

}

}
