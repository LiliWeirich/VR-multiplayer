using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
public class NetworkManager : MonoBehaviourPunCallbacks
{
    void Start()
    {
        ConnectedToServer();
    }
    private void ConnectedToServer()
    {
        PhotonNetwork.ConnectUsingSettings();
        Debug.Log("Try To Connect To Server...");
    }
    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected To Server.");
        base.OnConnectedToMaster();
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 5;
        roomOptions.IsVisible = true;
        roomOptions.IsOpen = true;
        PhotonNetwork.JoinOrCreateRoom("Room 1", roomOptions, TypedLobby.Default);
    }
    public override void OnJoinedRoom()
    {
        Debug.Log("Join a room.");
        base.OnJoinedRoom();
    }
    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        Debug.Log("New player joined the room");
        base.OnPlayerEnteredRoom(newPlayer);
    }
}
