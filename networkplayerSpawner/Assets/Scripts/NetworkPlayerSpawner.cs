using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class NetworkPlayerSpawner : MonoBehaviourPunCallbacks
{
    public Transform[] spawnPoints;
    public GameObject XRLocation;

    private bool doUpdate = false;
    private GameObject _spawnedPlayerPrefab;

    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();
        _spawnedPlayerPrefab = PhotonNetwork.Instantiate("Network Player", transform.position, transform.rotation);
        //_spawnedPlayerPrefab.transform.position = XROrigin.transform.position; //need to define XR origin
        
        
        doUpdate = true;
    }

    public void LateUpdate()
    {
        if(doUpdate)
        {
            int randomSpawn = Random.Range(0, spawnPoints.Length - 1);
            XRLocation.transform.position = new Vector3(spawnPoints[randomSpawn].position.x, 0.0f, spawnPoints[randomSpawn].position.z);
            XRLocation.transform.forward = spawnPoints[randomSpawn].forward; // turn so we are looking forward
            doUpdate = false;
        }
    }

    public override void OnLeftRoom()
    {
        base.OnLeftRoom();
        PhotonNetwork.Destroy(_spawnedPlayerPrefab);
    }
}
