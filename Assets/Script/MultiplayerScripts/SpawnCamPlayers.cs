using System;
using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using UnityEditor;
using UnityEngine;

public class SpawnCamPlayers : MonoBehaviour
{
    public GameObject player;
    public float minX, minY, minZ;
    public float rotation = 90;

    private void Start()
    {
        Vector3 position = new Vector3(minX, minY, minZ);
        PhotonNetwork.Instantiate(player.name, position,Quaternion.Euler(rotation,0,0));
    }
}
