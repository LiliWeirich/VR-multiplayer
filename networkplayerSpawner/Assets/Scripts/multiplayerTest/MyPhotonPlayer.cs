using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Photon.Realtime;
using Photon.Pun;
using Unity.XR.CoreUtils;
using UnityEngine.XR;

public class MyPhotonPlayer : MonoBehaviour
{
    private PhotonView myPV;
    GameObject myPlayerAvatar;

    Player[] allPlayers;
    int myNumberInRoom;

    // Start is called before the first frame update
    void Start()
    {
        myPV = GetComponent<PhotonView>();

        allPlayers = PhotonNetwork.PlayerList;
        foreach(Player p in allPlayers)
        {
           /* if(p! = PhotonNetwork.LocalPlayer)
            {
                myNumberInRoom ++;
            }
           */
        }

        if (myPV.IsMine)
        {
            myPlayerAvatar = PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "AU_Player"), GameController.instance.spawnPoints[myNumberInRoom].position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
