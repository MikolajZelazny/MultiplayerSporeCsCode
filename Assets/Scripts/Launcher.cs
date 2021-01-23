using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Launcher : MonoBehaviourPunCallback
{
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster(); 
    {
        //base.OnConnectedtoMaster();
        PhotonNetwork.JoinLobby();
    }


// Update is called once per frame
void Update()
{

}
}
